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
    public class GameManager: IGameManager
    {
        private readonly IGameDal _dal;

        public GameManager(IGameDal dal)
        {
            _dal = dal;
        }

        public void Add(Game game)
        {
            _dal.Add(game);
        }

        public List<Game> GetAllGames()
        {
            return _dal.GetGames();
        }

        public List<Game> GetGamesByPage(int pageNumber, int gamesPerPage)
        {
            return _dal.GetGamesByPage(pageNumber, gamesPerPage);
        }

        public List<Game> GetFeaturedGames()
        {
            return _dal.GetFeaturedGames();
        }
        public void Remove(int id)
        {
            var game = _dal.Get(c => c.Id == id);
            game.IsDeleted = true;
            _dal.Update(game);
        }

        public void Update(int id, Game game)
        {
            _dal.UpdateGame(id, game);
        }

        Task<Game> IGameManager.GetById(int gameId)
        {
            return _dal.GetById(gameId);
        }
    }
}
