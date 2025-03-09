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
        private readonly IGameCategoryManager _gameCategoryManager;
        private readonly IGamePlatformManager _gamePlatformManager;
        private readonly IGameLanguageTypeLManager _gameLanguageTypeLManager;
        private readonly IGameDeveloperManager _gameDeveloperManager;
        private readonly IMapper _mapper;

        public GameController(IGameManager gameManager, IMapper mapper, IGameCategoryManager gameCategoryManager, IGamePlatformManager gamePlatformManager, IGameLanguageTypeLManager gameLanguageTypeLManager, IGameDeveloperManager gameDeveloperManager)
        {
            _gameManager = gameManager;
            _mapper = mapper;
            _gameCategoryManager = gameCategoryManager;
            _gamePlatformManager = gamePlatformManager;
            _gameLanguageTypeLManager = gameLanguageTypeLManager;
            _gameDeveloperManager = gameDeveloperManager;
        }

        // GET: api/<GameController>
        [HttpGet]

        public List<GameDisplayDTO> GetGames()
        {
            var games = _gameManager.GetAllGames();
            var gameList = _mapper.Map<List<GameDisplayDTO>>(games);
            return gameList;

        }

        [HttpGet("page")]

        public List<GameDisplayDTO> GetGamesByPage(int pageNumber, int gamesPerPage)
        {
            var games = _gameManager.GetGamesByPage(pageNumber, gamesPerPage);
            var gameList = _mapper.Map<List<GameDisplayDTO>>(games);
            return gameList;

        }

        [HttpGet("featured")]

        public List<GameDisplayDTO> GetFeaturedGames()
        {
            var games = _gameManager.GetFeaturedGames();
            var gameList = _mapper.Map<List<GameDisplayDTO>>(games);
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
            var gameDto = _mapper.Map<GameDisplayDTO>(game);
            res.Value = new { status = 200, data = gameDto };
            return res;
        }

        // POST api/<GameController>
        [HttpPost]

        public JsonResult Add(GameInputDTO game)
        {
            JsonResult res = new(new { });
            try
            {
                var createdGame = _mapper.Map<Game>(game);

                _gameManager.Add(createdGame);
                foreach (var id in game.CategoryIds)
                {
                    var gameCategory = new GameCategory
                    {
                        GameId = createdGame.Id,
                        CategoryId = id
                    };
                    _gameCategoryManager.Add(gameCategory);


                }

                foreach (var id in game.PlatformIds)
                {
                    var gamePlatform = new GamePlatform
                    {
                        GameId = createdGame.Id,
                        PlatformId = id
                    };
                    _gamePlatformManager.Add(gamePlatform);
                    
                }
                foreach (var id in game.LanguageTypeLIds)
                {
                    var gameLanguageTypeL = new GameLanguageTypeL
                    {
                        GameId = createdGame.Id,
                        LanguageTypeLId = id
                    };
                    _gameLanguageTypeLManager.Add(gameLanguageTypeL);

                }
                foreach (var id in game.DeveloperIds)
                {
                    var gameDeveloper = new GameDeveloper
                    {
                        GameId = createdGame.Id,
                        DeveloperId = id
                    };
                    _gameDeveloperManager.Add(gameDeveloper);

                }
                res.Value = new { status = 201, message = "Game created succesfully"};
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
        public JsonResult Put(int? id, [FromBody] GameInputDTO game)
        {

            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var updatedGame = _mapper.Map<Game>(game);
            _gameManager.Update(id.Value, updatedGame);

            
            _gameCategoryManager.Update(game.CategoryIds, id.Value);

            _gamePlatformManager.Update(game.PlatformIds, id.Value);
            _gameDeveloperManager.Update(game.DeveloperIds, id.Value);
            _gameLanguageTypeLManager.Update(game.LanguageTypeLIds, id.Value);

            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<GameController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _gameManager.Remove(id);
        }

    }
}
