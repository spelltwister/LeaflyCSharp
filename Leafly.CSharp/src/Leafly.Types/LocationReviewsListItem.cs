using System;

namespace Leafly.Types
{
    public class LocationReviewsListItem {
        public double atmosphere { get; set; }
        public string avatar { get; set; }
        public string comments { get; set; }
        public DateTime date { get; set; }
        public double easeOfRegistration { get; set; }
        public bool firstVisit { get; set; }
        public int id { get; set; }
        public double meds { get; set; }
        public string overallRating { get; set; } // TODO: why string
        public double packagingQuality { get; set; }
        public double service { get; set; }
        public bool shopAgain { get; set; }
        public string starImage { get; set; }
        public string username { get; set; }
        public bool wouldRecommend { get; set; }
    }
}