using eOPG.ClassLibrary.Api.Enums;

namespace eOPG.ClassLibrary.Api.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public Guid FamilyFarmId { get; set; }
        public FamilyFarm FamilyFarm { get; set; }
        public VehicleType Type { get; set; }
        public int Mileage { get; set; }
        public int NextServiceMileage { get; set; }
        public DateTime LastServiceDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}
