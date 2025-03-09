using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Update(int id, Category category);
        void Remove(int id);
        Task<Category> GetById(int categoryId);
        Task<Category> GetByName(string categoryName);
        List<Category> GetAllCategories();
    }
}
