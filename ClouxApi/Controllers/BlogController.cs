using AutoMapper;
using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClouxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogManager _blogManager;
        private readonly IMapper _mapper;

        public BlogController(IBlogManager blogManager, IMapper mapper)
        {
            _blogManager = blogManager;
            _mapper = mapper;
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<BlogDisplayDto> GetBlogs()
        {
            var blogs = _blogManager.GetAllBlogs();
            var blogList = _mapper.Map<List<BlogDisplayDto>>(blogs);
            return blogList;

        }

        
        // GET api/<platformController>/5
        [HttpGet("{id}")]

        public async Task<JsonResult> GetBlogbyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Blog not found" };
                return res;
            }
            var blog = await _blogManager.GetById(id.Value);
            var blogDto = _mapper.Map<BlogDisplayDto>(blog);
            res.Value = new { status = 200, data = blogDto };
            return res;
        }

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(BlogInputDto blog)
        {
            JsonResult res = new(new { });
            try
            {
                var createdBlog = _mapper.Map<Blog>(blog);

                _blogManager.Add(createdBlog);
                
                res.Value = new { status = 201, message = "Blog created succesfully"};
                return res;
            }
            catch (Exception)
            {

                res.Value = new { status = 403, message = "Error" };
                return res;
            }

        }
       

        // PUT api/<platformController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int? id, [FromBody] BlogInputDto blog)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedBlog = _mapper.Map<Blog>(blog);
            _blogManager.Update(id.Value, updatedBlog);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _blogManager.Remove(id);
        }

    }
}
