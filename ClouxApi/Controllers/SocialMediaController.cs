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
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaManager _socialMediaManager;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaManager socialMediaManager, IMapper mapper)
        {
            _socialMediaManager = socialMediaManager;
            _mapper = mapper;
        }

        // GET: api/<SocialMediaController>
        [HttpGet]
        public List<SMDisplayDTO> Get()
        {

            var smList = _socialMediaManager.GetSocialMediaList();

            var mappedSocial = _mapper.Map<List<SMDisplayDTO>>(smList);
            return mappedSocial;
            
        }

        // GET api/<SocialMediaController>/5
        [HttpGet("{id}")]
        public SMDisplayDTO Get(int id)
        {
            var socialMedia = _socialMediaManager.GetSocialMediaById(id);
            var mappedSocial = _mapper.Map<SMDisplayDTO>(socialMedia);
            return mappedSocial;
        }

        

        // PUT api/<SocialMediaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SMInputDTO socialMedia)
        {
            var mappedSocial = _mapper.Map<SocialMedia>(socialMedia);
            _socialMediaManager.UpdateLink(id, mappedSocial);
        }

        // DELETE api/<SocialMediaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
