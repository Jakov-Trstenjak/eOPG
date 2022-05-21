using eOPG.ClassLibrary.Api.Enums;

namespace eOPG.Models
{
    public class Resource
    {
        public Guid FamilyFarmId { get; set; }
        public FamilyFarm FamilyFarm { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public ResourceType ResourceType { get; set; }
        public ResourceSubType SubType { get; set; }
    }
}
