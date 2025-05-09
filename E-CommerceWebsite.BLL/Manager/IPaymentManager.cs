using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebsite.BLL.Manager
{
    public interface IPaymentManager
    {
        Task<bool> ProcessCashOrderAsync();
        Task<bool> ProcessCreditOrderAsync();
        Task<bool> IncreaseBalance(decimal amount);
    }
}
