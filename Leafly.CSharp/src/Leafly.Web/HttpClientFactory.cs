﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Leafly.Web
{
    public class HttpClientFactory
    {
        private readonly string appKey;
        private readonly string appId;

        private readonly string strainEndpoint;
        private readonly string locationEndpoint;

        public HttpClientFactory(string appKey, string appId, string strainEndpoint = "http://data.leafly.com/strains", string locationEndpoint = "http://data.leafly.com/locations")
        {
            this.appKey = appKey;
            this.appId = appId;

            this.strainEndpoint = strainEndpoint;
            this.locationEndpoint = locationEndpoint;
        }

        private HttpClient GetBaseClient(string url)
        {
            var ret = new HttpClient() { BaseAddress = new Uri(url) };

            ret.DefaultRequestHeaders.Accept.Clear();
            ret.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            ret.DefaultRequestHeaders.Add("app_id", this.appId);
            ret.DefaultRequestHeaders.Add("app_key", this.appKey);

            return ret;
        }

        public HttpClient GetLocationClient()
        {
            return GetBaseClient($"{locationEndpoint}/");
        }

        public HttpClient GetStrainClient()
        {
            return GetBaseClient($"{strainEndpoint}/");
        }

        internal static async Task<T> GetAndReadAsAsync<T>(HttpClient client, string endpoint)
        {
            using (client)
            {
                var response = await client.GetAsync(endpoint).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<T>().ConfigureAwait(false);
            }
        }

        public Task<T> GetStrainClientAndReadAsAsync<T>(string endpoint)
        {
            return GetAndReadAsAsync<T>(GetStrainClient(), endpoint);
        }

        public Task<T> GetLocationClientAndReadAsAsync<T>(string endpoint)
        {
            return GetAndReadAsAsync<T>(GetLocationClient(), endpoint);
        }

        internal static async Task<T> PostAndReadAsAsync<T, U>(HttpClient client, string endpoint, U content)
        {
            using (client)
            {
                var response = await client.PostAsJsonAsync(endpoint, content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<T>().ConfigureAwait(false);
            }
        }

        public Task<T> PostStrainClientAndReadAsAsync<T, U>(string endpoint, U content)
        {
            return PostAndReadAsAsync<T, U>(GetBaseClient(strainEndpoint), endpoint, content); // NOTE: doesn't work with the trailing '/'
        }

        public Task<T> PostLocationClientAndReadAsAsync<T, U>(string endpoint, U content)
        {
            return PostAndReadAsAsync<T, U>(GetLocationClient(), endpoint, content);
        }
    }
}
