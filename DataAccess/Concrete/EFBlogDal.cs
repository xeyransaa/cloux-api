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
    public class EFBlogDal : EFEntityRepositary<ClouxDbContext, Blog>, IBlogDal
    {

        public async Task<Blog> GetById(int id)
        {
            using ClouxDbContext context = new();
            var blog = context.Blogs
              .Where(c => !c.IsDeleted && c.Id == id)
              .Include(c => c.BlogCategory)
              .Include(c => c.Author)
              .FirstOrDefaultAsync();
            return await blog;
        }

        public List<Blog> GetBlogs()
        {
            using ClouxDbContext context = new();
            var blogs = context.Blogs
              .Where(c => !c.IsDeleted)
              .Include(c => c.Author)
              .Include(c => c.BlogCategory)
              .ToList();
            return blogs;
        }


        public void UpdateBlog(int id, Blog blog)
        {
            using ClouxDbContext context = new();
            blog.Id = id;


            context.Blogs.Update(blog);
            context.SaveChanges();
        }

        public void AddBlog(Blog blog) { 
        
            using ClouxDbContext context = new();
            context.Blogs.Add(blog);
            context.SaveChanges();
                  
            
           
        }

        public void DeleteBlog(int id)
        {
            using ClouxDbContext context = new();
            var deletedBlog = context.Blogs.Where(g => g.Id == id).FirstOrDefault();
            deletedBlog.IsDeleted = true;
        }
    }
}
