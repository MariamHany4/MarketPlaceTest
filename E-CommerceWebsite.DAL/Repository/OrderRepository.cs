using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_CommerceWebsite.DAL.Data;
using E_CommerceWebsite.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using static E_CommerceWebsite.DAL.Data.Models.Order;

namespace E_CommerceWebsite.DAL.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly WebsiteContext _websiteContext;

        public OrderRepository(WebsiteContext websiteContext)
        {
            _websiteContext = websiteContext;
        }

        // Insert a new order
        public async Task InsertAsync(Order order)
        {
            await _websiteContext.Orders.AddAsync(order);
            await SaveChangesAsync();
        }

        // Get all orders
        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _websiteContext.Orders
                .AsNoTracking()
                .Include(order => order.OrderDetails)
                .ToListAsync();
        }

        // Get all orders for a specific user using string userId
        public async Task<IEnumerable<Order>> GetUserOrdersAsync(string userId)
        {
            var orders = await _websiteContext.Orders
                        .AsNoTracking()
                        .Where(order => order.UserId == userId)
                        .Include(order => order.OrderDetails)
                        .ToListAsync();

            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.Status}");
            }

            return orders;
        }

        // Create a cash order
        public async Task CreateCashOrderAsync(Order order)
        {
            await _websiteContext.Orders.AddAsync(order);
            await SaveChangesAsync();
        }

        // Update an existing order
        public async Task UpdateAsync(Order order)
        {
            _websiteContext.Orders.Update(order);
            await SaveChangesAsync();
        }

        // Checkout session logic
        public async Task CheckoutSessionAsync(int orderId)
        {
            var order = await _websiteContext.Orders.FindAsync(orderId);
            if (order != null)
            {
                order.Status = OrderStatus.Completed; // ✅ using the enum now
                await SaveChangesAsync();
            }
        }

        // Delete an order
        public async Task DeleteAsync(Order order)
        {
            _websiteContext.Orders.Remove(order);
            await SaveChangesAsync();
        }

        // Save changes to the database
        public async Task SaveChangesAsync()
        {
            await _websiteContext.SaveChangesAsync();
        }
    }
}
