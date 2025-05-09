using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using E_CommerceWebsite.DAL.Data.Models;

namespace E_CommerceWebsite.DAL.Repository
{
    public interface IOrderRepository
    {
        // Insert a new order
        Task InsertAsync(Order order);

        // Get all orders
        Task<IEnumerable<Order>> GetAllOrdersAsync();

        // Get all orders for a specific user
        Task<IEnumerable<Order>> GetUserOrdersAsync(string userId);

        // Create a cash order
        Task CreateCashOrderAsync(Order order);

        // Update an existing order
        Task UpdateAsync(Order order);

        // Checkout session logic
        Task CheckoutSessionAsync(int orderId);

        // Delete an order
        Task DeleteAsync(Order order);

        // Save changes to the database
        Task SaveChangesAsync();
    }
}
