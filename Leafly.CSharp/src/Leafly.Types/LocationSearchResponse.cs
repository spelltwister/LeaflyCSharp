using System.Collections.Generic;

namespace Leafly.Types
{
    public class LocationSearchResponse
    {
        public ICollection<StoreListItem> stores { get; set; }
        public PagingContext pagingContext { get; set; }
        //public object facets { get; set; }
    }
}