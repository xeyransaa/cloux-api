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
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageManager _languageManager;
        private readonly IMapper _mapper;

        public LanguageController(ILanguageManager languageManager, IMapper mapper)
        {
            _languageManager = languageManager;
            _mapper = mapper;
            
        }

        // GET: api/<platformController>
        [HttpGet]

        public List<LanguageDisplayDto> GetLanguages()
        {
            var languages = _languageManager.GetAllLanguages();
            var languageList = _mapper.Map<List<LanguageDisplayDto>>(languages);
            return languageList;

        }

        
        // GET api/<platformController>/5
        [HttpGet("{id}")]

        public async Task<JsonResult> GetLanguagebyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "Language not found" };
                return res;
            }
            var language = await _languageManager.GetById(id.Value);
            var languageDto = _mapper.Map<LanguageDisplayDto>(language);
            res.Value = new { status = 200, data = languageDto };
            return res;
        }

        // POST api/<platformController>
        [HttpPost]

        public JsonResult Add(LanguageDisplayDto language)
        {
            JsonResult res = new(new { });
            try
            {
                var createdLanguage = _mapper.Map<Language>(language);

                _languageManager.Add(createdLanguage);
                
                res.Value = new { status = 201, message = "Language created succesfully"};
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
        public JsonResult Put(int? id, [FromBody] LanguageDisplayDto language)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedLanguage = _mapper.Map<Language>(language);
            _languageManager.Update(id.Value, updatedLanguage);


            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<platformController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _languageManager.Remove(id);
        }

    }
}
