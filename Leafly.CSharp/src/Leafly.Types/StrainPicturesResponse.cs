using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainPicturesResponse
    {
        public PagingContext pagingContext { get; set; }
        public ICollection<StrainPicturesPictureListItem> photos { get; set; }
    }
}