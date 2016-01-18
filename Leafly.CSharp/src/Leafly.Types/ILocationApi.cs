using System.Threading.Tasks;

namespace Leafly.Types
{
    public interface ILocationApi
    {
        Task<LocationSearchResponse> Search(Position position, OptionalLocationSearchFilters filters, int page = 0, int take = 10);
        Task<LocationDetailsResponse> Details(string slug);
        Task<LocationMenuListItem[]> Menu(string slug);
        Task<LocationReviewsResponse> Reviews(string slug, int skip = 0, int take = 10);
        Task<LocationSpecialsListItem[]> Specials(string slug);
    }
}
