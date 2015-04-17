using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Summary_of_Sales_by_Quarter: Entity
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
