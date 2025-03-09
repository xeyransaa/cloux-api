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
    public class BlogManager: IBlogManager
    {
        private readonly IBlogDal _dal;

        public BlogManager(IBlogDal dal)
        {
            _dal = dal;
        }

        public void Add(Blog blog)
        {
            _dal.Add(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return _dal.GetBlogs();
        }

        public void Remove(int id)
        {
            var blog = _dal.Get(c => c.Id == id);
            blog.IsDeleted = true;
            _dal.Update(blog);
        }

        public void Update(int id, Blog blog)
        {
            _dal.UpdateBlog(id, blog);
        }

        Task<Blog> IBlogManager.GetById(int blogId)
        {
            return _dal.GetById(blogId);
        }
    }
}
