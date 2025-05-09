using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebsite.DAL.Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public ShoppingCart Cart { get; set; } = null!;
      //  public Address ShippingAddress { get; set; } = null!;
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public string PaymentMethod { get; set; } = null!;
        public decimal TaxPrice { get; set; } = 0;
        public decimal ShippingPrice { get; set; } = 0;
        public decimal TotalOrderPrice { get; set; } = 0;
        public bool IsPaid { get; set; } = false;
        public bool IsDelivered { get; set; } = false;
    }
}
