using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_CommerceWebsite.DAL.Data.Models
{
    public class Order
    {
        
        public OrderStatus Status { get; set; }

        public int OrderId { get; set; }

        // Foreign key to ApplicationUser (Identity User)
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public int? PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        public Payment Payment { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public string PaymentMethod { get; set; }
       // public string Status { get; set; }
        public decimal OrderTotal { get; set; }
    
        public string ShippingAddress { get; set; }
        public DateTime OrderPlaced { get; set; }
        public string? CouponCode { get; set; }
    }
}
