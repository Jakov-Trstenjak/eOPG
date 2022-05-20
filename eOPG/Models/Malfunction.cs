namespace eOPG.Models
{
    public class Malfunction
    {
        public Guid Id { get; set; }
        public Guid FamilyFarmId { get; set; }
        public FamilyFarm FamilyFarm { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Guid CreatedById { get; set; }
        public Person CreatedBy { get; set; }
    }
}
