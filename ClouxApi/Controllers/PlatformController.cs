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
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformManager _platformManager;
        private readonly IMapper _mapper;

        public PlatformController(IPlatformManager platformManager, IMapper mapper)
        {
            _platformManager = platformManager;
            _mapper = mapper;
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<PlatformDisplayDto> GetPlatforms()
        {
            var platforms = _platformManager.GetAllPlatforms();
            var platformList = _mapper.Map<List<PlatformDisplayDto>>(platforms);
            return platformList;

        }

        
        // GET api/<platformController>/5
        [HttpGet("id/{id}")]

        public async Task<JsonResult> GetPlatformbyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Platform not found" };
                return res;
            }
            var platform = await _platformManager.GetById(id.Value);
            var platformDto = _mapper.Map<PlatformDisplayDto>(platform);
            res.Value = new { status = 200, data = platformDto };
            return res;
        }

        [HttpGet("name/{name}")]

        public async Task<JsonResult> GetPlatformbyName(string? name)
        {
            JsonResult res = new(new { });
            
            var platform = await _platformManager.GetByName(name);
            var platformDto = _mapper.Map<PlatformDisplayDto>(platform);
            res.Value = new { status = 200, data = platformDto };
            return res;
        }

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(PlatformInputDto platform)
        {
            JsonResult res = new(new { });
            try
            {
                var createdPlatform = _mapper.Map<Platform>(platform);

                _platformManager.Add(createdPlatform);
                
                res.Value = new { status = 201, message = "Platform created succesfully"};
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
        public JsonResult Put(int? id, [FromBody] PlatformInputDto platform)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedplatform = _mapper.Map<Platform>(platform);
            _platformManager.Update(id.Value, updatedplatform);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _platformManager.Remove(id);
        }

    }
}
