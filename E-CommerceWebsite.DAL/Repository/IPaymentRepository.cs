using E_CommerceWebsite.DAL.Data.Models;

namespace E_CommerceWebsite.DAL.Repository
{
    public interface IPaymentRepository
    {
        Task<bool> ProcessCashOrderAsync(ShoppingCart Cart);
        Task<bool> ProcessCreditOrderAsync(ShoppingCart Cart);
        Task<bool> IncreaseBalance(ApplicationUser User, decimal amount);
        Task SaveChangesAsync();
    }
}