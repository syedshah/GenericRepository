using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Current_Product_List: Entity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
