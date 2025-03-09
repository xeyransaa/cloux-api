using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClouxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly TokenManager _tokenManager;


        public AccountController(UserManager<User> userManager, IMapper mapper, IConfiguration config, TokenManager tokenManager)
        {
            _userManager = userManager;
            _mapper = mapper;
            _config = config;
            _tokenManager = tokenManager;
        }

        // GET: api/<AccountController>
        [HttpGet]
        
        public List<User> GetUsers()
        {
            var users = _userManager.Users.ToList();
          
            return users;

        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
       
        public async Task<JsonResult> GetUserbyId(string id)
        {
            JsonResult res = new(new { });
            
            var user = await _userManager.FindByIdAsync(id);
            
            res.Value = new { status = 200, data = user };
            return res;
        }

        // POST api/<AccountController>
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegisterDto userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            var result = await _userManager.CreateAsync(user, userDTO.Password);
            if (!result.Succeeded)
            {
                return BadRequest();
            }
            return Ok(new { status = 201, message = "User created" });
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginDto userDTO)
        {
            var findUser = await _userManager.FindByNameAsync(userDTO.UserName);
            var checkPassword = await _userManager.CheckPasswordAsync(findUser, userDTO.Password);
            if (findUser != null && checkPassword)
            {

                var myToken = _tokenManager.GenerateToken(findUser);

                return Ok(new { token = myToken });
            }

            return Unauthorized();

        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
