using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_CommerceWebsite.BLL.Dtos;
using E_CommerceWebsite.DAL.Data.Models;
using E_CommerceWebsite.DAL.Repository;

namespace E_CommerceWebsite.BLL.Manager
{

    public interface IProfileManager
    {
        Task<CategoryReadDto> GetByIdAsync(int id);
        Task InsertAsync(CategoryAddDto category);
        Task UpdateAsync(CategoryUpdateDto category);
        //Task DeleteAsync(int id);
    }
}