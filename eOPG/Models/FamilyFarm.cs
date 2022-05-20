namespace eOPG.Models
{
    public class FamilyFarm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
