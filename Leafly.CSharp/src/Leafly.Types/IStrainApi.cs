using System.Threading.Tasks;

namespace Leafly.Types
{
    public interface IStrainApi
    {
        Task<StrainSearchResponse> Search(string searchTerm, string sort, OptionalStrainSearchFilters filters, int page = 0, int take = 10);
        Task<StrainDetailsResponse> Details(string slug);
        Task<StrainReviewsResponse> Reviews(string slug, int page = 0, int take = 10, string sort = "rating");
        Task<StrainReviewDetailsResponse> ReviewDetails(string slug, int reviewId);
        Task<StrainPicturesResponse> Pictures(string slug, int page = 0, int take = 10);
        Task<StrainAvailabilityResponseListItem[]> Availability(string slug, double latitude, double longitude, double? radius, string productTypeFilter);
    }
}
