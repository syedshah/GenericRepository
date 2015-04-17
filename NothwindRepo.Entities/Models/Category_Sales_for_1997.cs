using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Category_Sales_for_1997: Entity
    {
        public string CategoryName { get; set; }
        public Nullable<decimal> CategorySales { get; set; }
    }
}
