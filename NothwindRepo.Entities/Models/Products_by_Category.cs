using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Products_by_Category: Entity
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
