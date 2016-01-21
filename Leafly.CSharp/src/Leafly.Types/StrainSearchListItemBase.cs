namespace Leafly.Types
{
    public abstract class StrainSearchListItemBase
    {
        public string Id { get; set; } // note: this is more like slug and is string type, not int
        public int Category { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string DisplayLabel { get; set; }
    }
}