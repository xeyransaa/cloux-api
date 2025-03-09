using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepositary<Category>
    {
        List<Category> GetCategories();


        Task<Category> GetById(int id);
        Task<Category> GetByName(string name);

        public void AddCategory(Category category);
        public void UpdateCategory(int id, Category category);
        public void DeleteCategory(int id);
        
    }
}
