using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Update(int id, Game game);
        void Remove(int id);
        Task<Game> GetById(int gameId);
        List<Game> GetAllGames();
        List<Game> GetGamesByPage(int pageNumber, int gamesPerPage);

        List<Game> GetFeaturedGames();
    }
}
