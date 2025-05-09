using System;
using System.Collections.Generic;

public class CheckoutDto
{
    public int OrderId { get; set; }  // The order being checked out
    public string UserId { get; set; }  // The ID of the user completing the checkout
    public List<int> ProductIds { get; set; }  // List of product IDs in the order
    public decimal TotalAmount { get; set; }  // Total cost of the order
    public string PaymentMethod { get; set; }  // Payment method chosen (e.g., "Credit Card", "PayPal")
    public string BillingAddress { get; set; }  // Billing address for payment
    public string ShippingAddress { get; set; }  // Shipping address for delivery
    public string? CouponCode { get; set; }  // Optional: Coupon code for discounts
    public DateTime CheckoutDate { get; set; }  // Date when checkout is being completed

    // Optional: Additional fields for tracking payment or discount info
    public string? PaymentStatus { get; set; }  // Status of the payment (e.g., "Pending", "Completed")
    public bool IsGift { get; set; }  // Whether the order is marked as a gift
}
