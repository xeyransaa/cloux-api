using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGameDal : IEntityRepositary<Game>
    {
        List<Game> GetGames();

        List<Game> GetFeaturedGames();

        Task<Game> GetById(int id);
        List<Game> GetGamesByPage(int pageNumber, int gamesPerPage);

        public void AddGame(Game game);
        public void UpdateGame(int id, Game game);
        public void RemoveGame(int id);
        
    }
}
