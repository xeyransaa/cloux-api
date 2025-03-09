using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFCategoryDal : EFEntityRepositary<ClouxDbContext, Category>, ICategoryDal
    {

        public async Task<Category> GetById(int id)
        {
            using ClouxDbContext context = new();
            var category = context.Categories
              .Where(c => !c.IsDeleted && c.Id == id)
              .Include(c => c.GameCategories)
              .ThenInclude(c => c.Game)
              .FirstOrDefaultAsync();
            return await category;
        }

        public async Task<Category> GetByName(string name)
        {
            using ClouxDbContext context = new();
            var category = context.Categories
              .Where(c => !c.IsDeleted && c.Name == name)
              .Include(c => c.GameCategories)
              .ThenInclude(c => c.Game)
              .FirstOrDefaultAsync();
            return await category;
        }
        public List<Category> GetCategories()
        {
            using ClouxDbContext context = new();
            var categories = context.Categories
              .Where(c => !c.IsDeleted)
              .Include(c => c.GameCategories)
              .ThenInclude(c => c.Game)
              .ToList();
            return categories;
        }


        public void UpdateCategory(int id, Category category)
        {
            using ClouxDbContext context = new();
            category.Id = id;


            context.Categories.Update(category);
            context.SaveChanges();
        }

        public void AddCategory(Category category) { 
        
            using ClouxDbContext context = new();
            context.Categories.Add(category);
            context.SaveChanges();
                  
            
           
        }

        public void DeleteCategory(int id)
        {
            using ClouxDbContext context = new();
            var deletedCategory = context.Categories.Where(g => g.Id == id).FirstOrDefault();
            deletedCategory.IsDeleted = true;
        }
    }
}
