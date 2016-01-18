using System;
using System.Collections.Generic;

namespace Leafly.Types
{
    public class LocationDetailsResponse
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public bool atm { get; set; }
        public bool creditCards { get; set; }
        public bool veteranDiscount { get; set; }
        public bool ada { get; set; }
        public bool isInfoOnlyListing { get; set; }
        public bool delivery { get; set; }
        public bool retail { get; set; }
        public bool medical { get; set; }
        public bool storefront { get; set; }
        public bool specials { get; set; }
        public int specialsCount { get; set; }
        public string logo { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public bool validPhone { get; set; }
        public bool approved { get; set; }
        public string hours { get; set; }
        public string website { get; set; }
        public string blurb { get; set; }
        public DateTime lastMenuUpdate { get; set; }
        public double rating { get; set; }
        public double meds { get; set; }
        public double service { get; set; }
        public double atmosphere { get; set; }
        public int followerCount { get; set; }
        public int reviewCount { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public ICollection<string> photos { get; set; }
        public int photoCount { get; set; }
        public string permalink { get; set; }
        public bool menu { get; set; }
        public bool preOrderEnabled { get; set; }
        public bool canadaLP { get; set; }
        public string coverPhoto { get; set; }
        public string tagLine { get; set; }
        public string tagLineBlurb { get; set; }
        public string facebookUrl { get; set; }
        public string twitterUrl { get; set; }
        public string googlePlusUrl { get; set; }
        public string pinterestUrl { get; set; }
        public string tumblrUrl { get; set; }
        public string instagramUrl { get; set; }
        public string starImage { get; set; }
        public ICollection<SpecialListItem> specialsList { get; set; }
        public ICollection<RecentReviewsListItem> recentReviews { get; set; }
        //public ICollection<object> updates{get;set;}
        public int updateCount { get; set; }
    }
}