using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebsite.DAL.Data.Models
{
    public enum OrderStatus
    {
        Pending,    // Order is pending
        Completed,  // Order is completed
        Shipped,    // Order has been shipped
        Cancelled   // Order is cancelled
    }
}

