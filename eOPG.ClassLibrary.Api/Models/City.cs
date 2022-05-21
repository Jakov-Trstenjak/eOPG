namespace eOPG.ClassLibrary.Api.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public string Name { get; set; }
    }
}
