using System;
using System.ComponentModel.DataAnnotations;
using E_CommerceWebsite.DAL.Data.Models;

public class OrderDetail
{
    [Key] // Primary key annotation
    public int OrderDetailID { get; set; }

    public int OrderID { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }

    // Navigation properties for relationships with other entities
    public virtual Product Product { get; set; }
    public virtual Order Order { get; set; }
}
