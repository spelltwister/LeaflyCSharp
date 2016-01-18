using System;
using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainReviewDetailsResponse
    {
        public string avatar { get; set; }
        public DateTime dateAdded { get; set; }
        //public ICollection<object> effects { get; set; }
        public ICollection<string> flavors { get; set; }
        public double form { get; set; }
        public int id { get; set; }
        public double locationLat { get; set; }
        public string locationLogo { get; set; }
        public double locationLon { get; set; }
        public string locationName { get; set; }
        public double locationRating { get; set; }
        public int locationReviewCount { get; set; }
        public string locationSlug { get; set; }
        public string locationStars { get; set; }
        public string locationTag { get; set; }
        public int method { get; set; }
        //public ICollection<object> negatives { get; set; }
        public string notes { get; set; }
        public string permalink { get; set; }
        public string photo { get; set; }
        public double rating { get; set; }
        public string starImage { get; set; }
        public string strainCategory { get; set; }
        public int strainId { get; set; }
        public string strainName { get; set; }
        public string strainSlug { get; set; }
        public string strainSymbol { get; set; }
        //public ICollection<object> symptoms { get; set; }
        public int userId { get; set; }
        public string username { get; set; }
    }
}