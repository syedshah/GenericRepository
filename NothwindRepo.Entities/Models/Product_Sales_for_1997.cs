using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Product_Sales_for_1997: Entity
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductSales { get; set; }
    }
}
