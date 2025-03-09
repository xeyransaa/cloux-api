using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClouxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<CategoryDisplayDto> GetCategories()
        {
            var categories = _categoryManager.GetAllCategories();
            var categoryList = _mapper.Map<List<CategoryDisplayDto>>(categories);
            return categoryList;

        }

        
        // GET api/<platformController>/5
        [HttpGet("id/{id}")]

        public async Task<JsonResult> GetCategorybyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Category not found" };
                return res;
            }
            var category = await _categoryManager.GetById(id.Value);
            var categoryDto = _mapper.Map<CategoryDisplayDto>(category);
            res.Value = new { status = 200, data = categoryDto };
            return res;
        }

        [HttpGet("name/{name}")]

        public async Task<JsonResult> GetCategorybyName(string? name)
        {
            JsonResult res = new(new { });

            var category = await _categoryManager.GetByName(name);
            var categoryDto = _mapper.Map<CategoryDisplayDto>(category);
            res.Value = new { status = 200, data = categoryDto };
            return res;
        }

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(CategoryInputDto category)
        {
            JsonResult res = new(new { });
            try
            {
                var createdCategory = _mapper.Map<Category>(category);

                _categoryManager.Add(createdCategory);
                
                res.Value = new { status = 201, message = "Category created succesfully"};
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
        public JsonResult Put(int? id, [FromBody] CategoryInputDto category)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedCategory = _mapper.Map<Category>(category);
            _categoryManager.Update(id.Value, updatedCategory);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryManager.Remove(id);
        }

    }
}
