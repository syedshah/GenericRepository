using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Sales_by_Category: Entity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductSales { get; set; }
    }
}
