using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        void Add(Blog blog);
        void Update(int id, Blog blog);
        void Remove(int id);
        Task<Blog> GetById(int blogId);
        List<Blog> GetAllBlogs();
    }
}
