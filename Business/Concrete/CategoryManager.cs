using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager: ICategoryManager
    {
        private readonly ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(Category category)
        {
            _dal.Add(category);
        }

        public List<Category> GetAllCategories()
        {
            return _dal.GetCategories();
        }

        public Task<Category> GetByName(string categoryName)
        {
            return _dal.GetByName(categoryName);
        }

        public void Remove(int id)
        {
            var category = _dal.Get(c => c.Id == id);
            category.IsDeleted = true;
            _dal.Update(category);
        }

        public void Update(int id, Category category)
        {
            _dal.UpdateCategory(id, category);
        }

        Task<Category> ICategoryManager.GetById(int categoryId)
        {
            return _dal.GetById(categoryId);
        }
    }
}
