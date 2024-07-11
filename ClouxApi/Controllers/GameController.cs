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
    public class GameController : ControllerBase
    {
        private readonly IGameManager _gameManager;
        private readonly IMapper _mapper;

        public GameController(IGameManager gameManager, IMapper mapper)
        {
            _gameManager = gameManager;
            _mapper = mapper;
        }

        // GET: api/<GameController>
        [HttpGet]

        public List<GameOutDTO> GetGames()
        {
            var games = _gameManager.GetAllGames();
            var gameList = _mapper.Map<List<GameOutDTO>>(games);
            return gameList;

        }

        [HttpGet("featured")]

        public List<GameOutDTO> GetFeaturedGames()
        {
            var games = _gameManager.GetFeaturedGames();
            var gameList = _mapper.Map<List<GameOutDTO>>(games);
            return gameList;

        }
        // GET api/<GameController>/5
        [HttpGet("{id}")]

        public async Task<JsonResult> GetGamebyId(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404, message = "game not found" };
                return res;
            }
            var game = await _gameManager.GetById(id.Value);
            var gameDto = _mapper.Map<GameOutDTO>(game);
            res.Value = new { status = 200, data = gameDto };
            return res;
        }
        
        // POST api/<GameController>
        [HttpPost]

        public JsonResult Add(Game game)
        {
            JsonResult res = new(new { });
            try
            {
                _gameManager.Add(game);
                res.Value = new { status = 201, message = "game created succesfully" };
                return res;
            }
            catch (Exception)
            {

                res.Value = new { status = 403, message = "Error" };
                return res;
            }

        }
       

        // PUT api/<GameController>/5
        [HttpPut("{id}")]
        public JsonResult Put(int? id, [FromBody] Game game)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            _gameManager.Update(id.Value, game);
            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<GameController>/5
        
    }
}
