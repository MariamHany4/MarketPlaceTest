using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_CommerceWebsite.BLL.Dtos;
using E_CommerceWebsite.BLL.Dtos.AccountDto;
using E_CommerceWebsite.DAL.Data.Models;
using E_CommerceWebsite.DAL.Repository;

namespace E_CommerceWebsite.BLL.Manager
{
    public class ProfileManager : IProfileManager
    {
        private readonly IProfileRepository profilerepository;

        public ProfileManager(IProfileRepository _profileRepository)
        {
            profilerepository = _profileRepository;
        }


        //public async Task DeleteAsync(int Id)
        //{
        //    var categorymodel = await _profilerepository.GetByIdAsync(Id);
        //    if (categorymodel != null)
        //    {
        //        await _profilerepository.deleteAsync(categorymodel);
        //        await _profilerepository.SaveChangesAsync();
        //    }
        //}


        //public async Task InsertAsync(CategoryAddDto category)
        //{
        //    var Categorymodel = new Category
        //    {
        //        CategoryName = category.CategoryName

        //    };

        //    await _categoryrepository.insertAsync(Categorymodel);
        //    await _categoryrepository.SaveChangesAsync();
        //}


        //public async Task UpdateAsync(ProfileUpdateDto profile)
        //{
        //    var Categorymodel = await profilerepository.
        //    if (Categorymodel != null)
        //    {
        //        Categorymodel.CategoryName = category.CategoryName;

        //        await profilerepository.updateprofile(Categorymodel);
        //        await profilerepository.SaveChangesAsync();
        //    }
        //}



        //public async Task<CategoryReadDto> GetByNameAsync(string Name)
        //{
        //    var CategoryModel = await profilerepository.GetByNameAsync(Name);
        //    if (CategoryModel != null)
        //    {
        //        var CategoryDto = new CategoryReadDto
        //        {
        //            CategoryId = CategoryModel.CategoryId,
        //            CategoryName = CategoryModel.CategoryName,

        //        };

        //        return CategoryDto;
        //    }

        //    return null;
        //}

        public Task<CategoryReadDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(CategoryAddDto category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CategoryUpdateDto category)
        {
            throw new NotImplementedException();
        }



        //public async Task<CategoryReadDto> GetByIdAsync(int id)
        //{
        //    var CategoryModel = await _categoryrepository.GetByIdAsync(id);
        //    if (CategoryModel != null)
        //    {
        //        var CategoryDto = new CategoryReadDto
        //        {
        //            CategoryId = CategoryModel.CategoryId,
        //            CategoryName = CategoryModel.CategoryName,

        //        };

        //        return CategoryDto;
        //    }

        //    return null;
        //}
    }
}
