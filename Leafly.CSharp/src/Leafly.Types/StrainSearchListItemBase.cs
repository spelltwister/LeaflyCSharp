namespace Leafly.Types
{
    public abstract class StrainSearchListItemBase
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string DisplayLabel { get; set; }
    }
}