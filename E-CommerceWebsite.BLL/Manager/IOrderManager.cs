using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IOrderManager
{
    // Create a new cash order
    Task CreateCashOrderAsync(OrderCreateDto orderCreateDto);

    // Get all orders
    Task<IEnumerable<OrderDto>> GetAllOrdersAsync();

    // Get orders for a specific user
    Task<IEnumerable<OrderDto>> GetUserOrdersAsync(string userId);

    // Complete the checkout session and change the order status to 'Completed'
    Task CheckoutSessionAsync(int orderId);
}
