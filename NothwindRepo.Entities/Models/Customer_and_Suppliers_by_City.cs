using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Customer_and_Suppliers_by_City: Entity
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
