using System.Collections.Generic;

namespace Leafly.Types
{
    public class OptionalStrainSearchFilters
    {
        /// <summary>
        /// List of effects to exclude(eg, "dry-mouth")
        /// </summary>
        public ICollection<string> exclude { get; set; }

        /// <summary>
        /// List of flavors to include
        /// </summary>
        public ICollection<string> flavors { get; set; }

        /// <summary>
        /// Strain types to include
        /// </summary>
        public ICollection<string> category { get; set; }

        /// <summary>
        /// Medical conditions to include
        /// </summary>
        public ICollection<string> conditions { get; set; }

        /// <summary>
        /// General effect tags to include
        /// </summary>
        public ICollection<string> tags { get; set; }

        /// <summary>
        /// Specific symptoms to include
        /// </summary>
        public ICollection<string> symptoms { get; set; }
    }
}