using E_CommerceWebsite.DAL.Data.Models;
using E_CommerceWebsite.DAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebsite.BLL.Manager
{
    public class PaymentManager : IPaymentManager
    {
        private readonly IPaymentRepository _paymentrepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IShoppingCartRepository _shoppingcartrepository;

        public PaymentManager(IPaymentRepository paymentrepository, IHttpContextAccessor httpContextAccessor, IShoppingCartRepository shoppingcartrepository)
        {
            _paymentrepository = paymentrepository;
            _httpContextAccessor = httpContextAccessor;
            _shoppingcartrepository = shoppingcartrepository;
        }
        public async Task<bool> ProcessCashOrderAsync()
        {
            var CartId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if(CartId == null)
                throw new Exception("Cart not sent");
            var cart = await _shoppingcartrepository.GetByIdAsync(CartId);
            if (cart == null) throw new Exception("Cart not found");
            return await _paymentrepository.ProcessCashOrderAsync(cart);
            throw new NotImplementedException();
        }

        public async Task<bool> ProcessCreditOrderAsync()
        {
            var CartId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (CartId == null)
                throw new Exception("Cart not sent");
            var cart = await _shoppingcartrepository.GetByIdAsync(CartId);
            if (cart == null) throw new Exception("Cart not found");
            return await _paymentrepository.ProcessCreditOrderAsync(cart);
            throw new NotImplementedException();
        }
        public async Task<bool> IncreaseBalance(decimal amount)
        {
            var CartId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (CartId == null)
                throw new Exception("Cart not sent");
            var cart = await _shoppingcartrepository.GetByIdAsync(CartId);
            if (cart == null) throw new Exception("Cart not found");
            var user = await _shoppingcartrepository.GetUserAsync(CartId);
            if (user == null) throw new Exception("User not found");
            return await _paymentrepository.IncreaseBalance(user,amount);
            throw new NotImplementedException();
        }

    }
}
