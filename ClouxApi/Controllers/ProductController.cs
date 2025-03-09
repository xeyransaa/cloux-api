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
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        private readonly IMapper _mapper;

        public ProductController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<ProductDto> GetProducts()
        {
            var products = _productManager.GetAllProducts();
            var productList = _mapper.Map<List<ProductDto>>(products);
            return productList;

        }

        
        // GET api/<platformController>/5
        [HttpGet("{id}")]

        public async Task<JsonResult> GetProductbyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Product not found" };
                return res;
            }
            var product = await _productManager.GetById(id.Value);
            var productDto = _mapper.Map<ProductDto>(product);
            res.Value = new { status = 200, data = productDto };
            return res;
        }

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(ProductDto product)
        {
            JsonResult res = new(new { });
            try
            {
                var createdProduct = _mapper.Map<Product>(product);

                _productManager.Add(createdProduct);
                
                res.Value = new { status = 201, message = "Product created succesfully"};
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
        public JsonResult Put(int? id, [FromBody] ProductDto product)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedProduct = _mapper.Map<Product>(product);
            _productManager.Update(id.Value, updatedProduct);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productManager.Remove(id);
        }

    }
}
