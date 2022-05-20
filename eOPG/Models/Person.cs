namespace eOPG.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public Guid FamilyFarmId { get; set; }
        public FamilyFarm FamilyFarm { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsOwner { get; set; }
        public float Salary { get; set; }
    }
}
