using System;
using System.Collections.Generic;

namespace Leafly.Types
{
    public class LocationMenuListItem
    {
        public DateTime addedOn { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        public string name { get; set; }
        public bool preOrderEnabled { get; set; }
        public ICollection<LocationMenuPricingListItem> pricing { get; set; }
        public string type { get; set; }
    }
}