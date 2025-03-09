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
    public interface IBlogDal : IEntityRepositary<Blog>
    {
        List<Blog> GetBlogs();


        Task<Blog> GetById(int id);

        public void AddBlog(Blog blog);
        public void UpdateBlog(int id, Blog blog);
        public void DeleteBlog(int id);
        
    }
}
