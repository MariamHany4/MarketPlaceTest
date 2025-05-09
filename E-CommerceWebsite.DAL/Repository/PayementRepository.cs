using E_CommerceWebsite.DAL.Data;
using E_CommerceWebsite.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static E_CommerceWebsite.DAL.Repository.PayementRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebsite.DAL.Repository
{
    public class PayementRepository(WebsiteContext context) : IPaymentRepository
    {
        private readonly WebsiteContext _context = context;

        public async Task<bool> ProcessCashOrderAsync(ShoppingCart Cart)
        {
            if (Cart == null) {return false;}
            if(Cart.CartItems == null || !Cart.CartItems.Any()) { return false;}
            // Get the user who placed the order
            var user = await _context.users.FindAsync(Cart.UserId.ToString());
            if (user == null) { return false; }
            // Check if user has sufficient balance
            if (user.balance < Cart.TotalPrice) { return false; }
            // Process each product in the order
            foreach (var cartItem in Cart.CartItems)
            {
                // Get the product
                var product = await _context.products
                    .Include(p => p.ApplicationUser)
                    .FirstOrDefaultAsync(p => p.ProductId == cartItem.ProductId);

                if (product == null || product.ApplicationUser == null) { return false; }

                // Add the product cost to the seller's balance
                product.ApplicationUser.balance += product.Price ?? 0 * cartItem.Quantity;
                _context.users.Update(product.ApplicationUser);
            }
            // Deduct the order total from the buyer's balance
            user.balance -= Cart.TotalPrice;
            _context.users.Update(user);
            Cart.CartItems = [];
            Cart.TotalPrice = 0;
            Cart.Status = "Paid";
            _context.ShoppingCart.Update(Cart);
            await SaveChangesAsync();
            return true;
        }

        public async Task<bool> ProcessCreditOrderAsync(ShoppingCart Cart)
        {
            if (Cart == null) { return false; }
            if (Cart.CartItems == null || !Cart.CartItems.Any()) { return false; }
            // Get the user who placed the order
            //var user = await _context.users.FindAsync(order.UserId.ToString());
            //if (user == null) { return false; }

            Cart.CartItems = [];
            Cart.TotalPrice = 0;
            Cart.Status = "Paid";
            _context.ShoppingCart.Update(Cart);
            await SaveChangesAsync();
            return true;
        }

        public async Task <bool> IncreaseBalance(ApplicationUser User, decimal amount)
        {
            if (User == null) { return false; }
            if (amount <= 0) return false;
            User.balance += amount;
            _context.users.Update(User);
            await SaveChangesAsync();
            return true;
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
