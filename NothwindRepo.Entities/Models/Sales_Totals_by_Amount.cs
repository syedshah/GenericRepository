using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Sales_Totals_by_Amount: Entity
    {
        public Nullable<decimal> SaleAmount { get; set; }
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
