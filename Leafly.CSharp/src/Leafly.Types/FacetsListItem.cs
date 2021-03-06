namespace Leafly.Types
{
    public class FacetsListItem
    {
        public string Label { get; set; }
        public string DisplayLabel { get; set; }
        public int Hits { get; set; }
        public string TagId { get; set; }
        public string Category { get; set; }
        public bool Selected { get; set; }
        public bool NoFollow { get; set; }
    }
}