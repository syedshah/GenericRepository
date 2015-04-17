using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Products_Above_Average_Price: Entity
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
