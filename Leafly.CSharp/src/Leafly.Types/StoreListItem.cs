using System;
using System.Collections.Generic;

namespace Leafly.Types
{
    public class StoreListItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string hours { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string locationLabel { get; set; }
        public bool delivery { get; set; }
        public bool storefront { get; set; }
        public DateTime lastMenuUpdate { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double rating { get; set; }
        public int numReviews { get; set; }
        public bool sponsor { get; set; }
        public bool ada { get; set; }
        public bool creditCards { get; set; }
        public bool atm { get; set; }
        public bool marquee { get; set; }
        public string coverPhoto { get; set; }
        public int logoId { get; set; }
        public string logo { get; set; }
        public bool medical { get; set; }
        public bool retail { get; set; }
        public bool price1 { get; set; }
        public bool price2 { get; set; }
        public bool price3 { get; set; }
        public int mapMarkerLevel { get; set; }
        public bool canadaLP { get; set; }
        public string tagLine { get; set; }
        public string permalink { get; set; }
        public string starImage { get; set; }
        public string customMarker { get; set; }
        public string customMarker2x { get; set; }
        public string mapMarker { get; set; }
        public ICollection<StoreListSpecialListItem> specials { get; set; }
    }
}