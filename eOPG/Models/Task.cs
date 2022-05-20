namespace eOPG.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public Guid FamilyFarmId { get; set; }
        public FamilyFarm FamilyFarm { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public Guid CreatedById { get; set; }
        public Person CreatedBy { get; set; }
        public Guid AssignedToId { get; set; }
        public Person AssignedTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateFinished { get; set; }
    }
}
