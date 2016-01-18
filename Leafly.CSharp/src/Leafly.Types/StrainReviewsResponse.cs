using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainReviewsResponse {
        public PagingContext pagingContext { get; set; }
        public ICollection<StrainReviewsReviewListItem> reviews { get; set; }
    }
}