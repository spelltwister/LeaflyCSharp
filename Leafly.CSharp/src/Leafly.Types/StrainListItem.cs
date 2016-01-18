using System.Collections.Generic;

namespace Leafly.Types
{
    public class StrainListItem
    {
        public int Id { get; set; }
        public string UrlName { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // strain type
        public string DisplayCategory { get; set; }
        public string Symbol { get; set; } // periodic table abbreviation
        public int RatingCount { get; set; }
        public int ReviewCount { get; set; }
        public double Rating { get; set; }
        public string StarImage { get; set; }
        public ICollection<TagListItem> Tags { get; set; }
        public ICollection<NegativeEffectsListItem> NegativeEffects { get; set; }
        public ICollection<FlavorListItem> Flavors { get; set; }
        public ICollection<SymptomsListItem> Symptoms { get; set; }
        public ICollection<ConditionsListItem> Conditions { get; set; }
        public string permalink { get; set; }
        public string SortName { get; set; }
        public ICollection<string> LogTags { get; set; }
    }
}