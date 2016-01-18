using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainSearchResponse
    {
        public ICollection<FacetsListItem> Facets { get; set; }
        public bool LocationFilter { get; set; }
        public string LocationUrl { get; set; }
        public PagingContext PagingContext { get; set; }
        public ICollection<SortsSearchResultsListItem> Sorts { get; set; }
        public ICollection<StrainListItem> Strains { get; set; }
    };
}