using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceWebsite.BLL.Dtos.AccountDto
{
    public class ProfileUpdateDto
    {
        public string? UserName { get; set; }
        public string? OwnerImage { get; set; }
        public string? Bio { get; set; }
    }
}
