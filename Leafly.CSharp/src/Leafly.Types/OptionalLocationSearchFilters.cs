using System.Collections.Generic;

namespace Leafly.Types
{
    public class OptionalLocationSearchFilters
    {
        public bool? storefront { get; set; }
        public bool? delivery { get; set; }
        public bool? retail { get; set; }
        public bool? medical { get; set; }
        public bool? creditcards { get; set; }
        public bool? hasclones { get; set; }
        public bool? hasconcentrates { get; set; }
        public bool? hasedibles { get; set; }
        public bool? veterandiscount { get; set; }

        public ICollection<int> strainIds { get; set; }
    }
}