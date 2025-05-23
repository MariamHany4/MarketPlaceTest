﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace E_CommerceWebsite.DAL.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        
        public string? OwnerImage { get; set; }
        public string? Bio { get; set; }
        public string? Password { get; set; }
        public int ? ShoppingCartId { get; set; }
        [ForeignKey("ShoppingCartId")]
        public ShoppingCart? ShoppingCart { get; set; }
        public decimal? balance { get; set; }
        public ICollection<Order> Orders { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
