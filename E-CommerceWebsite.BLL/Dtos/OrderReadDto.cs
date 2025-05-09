using System;
using System.Collections.Generic;

public class OrderReadDto
{
    public int OrderId { get; set; }
    public string UserId { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
    public string ShippingAddress { get; set; }
    public DateTime OrderDate { get; set; }
    public List<string> ProductTitles { get; set; }
    public string? CouponCode { get; set; }
}
