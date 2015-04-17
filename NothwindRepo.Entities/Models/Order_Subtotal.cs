using System;
using Repository.Pattern.Ef6;

namespace NorthwindRepo.Entities.Models
{
    public partial class Order_Subtotal: Entity
    {
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
