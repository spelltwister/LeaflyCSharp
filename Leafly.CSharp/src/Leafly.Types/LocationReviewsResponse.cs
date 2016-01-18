using System.Collections.Generic;

namespace Leafly.Types
{
    public class LocationReviewsResponse
    {
        public PagingContext pagingContext { get; set; }
        public ICollection<LocationReviewsListItem> reviews { get; set; }
    }
}