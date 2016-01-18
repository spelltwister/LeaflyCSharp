using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainDetailsResponse {
        public string aka{get;set;}
        public int articleTotalCount{get;set;}
        public ICollection<StrainDetailsArticleListItem> articles { get; set; }
        public bool articlesAvailable{get;set;}
        public string category{get;set;}
        public ICollection<StrainDetailsConditionsListItem> conditions { get; set; }
        public string description{get;set;}
        public string descriptionPlain{get;set;}
        public ICollection<StrainDetailsEffectsListItem> effects { get; set; }
        public ICollection<StrainDetailsFlavorsListItem> flavors { get; set; }
        public ICollection<StrainDetailsHighlightedReviewListItem> highlightedReviews { get; set; }
        public int id{get;set;}
        public string name{get;set;}
        public ICollection<StrainDetailsNegativesListItem> negatives { get; set; }
        public ICollection<StrainDetailsParentsListItem> parents { get; set; }
        public string permalink{get;set;}
        public int photoTotalCount{get;set;}
        public ICollection<StrainDetailsPhotosListItem> photos { get; set; }
        public ICollection<string> popularCities { get; set; }
        public double rating{get;set;}
        public ICollection<StrainDetailsRelatedStrainsListItem> relatedStrains { get; set; }
        public int reviewCount{get;set;}
        public string slug{get;set;}
        public string starImage{get;set;}
        public string symbol{get;set;}
        public ICollection<StrainDetailsSymptomsListItem> symptoms { get; set; }
        public string testGraph{get;set;}
        public string videoUrl{get;set;}
        public string weakDescription{get;set;}
    };
}