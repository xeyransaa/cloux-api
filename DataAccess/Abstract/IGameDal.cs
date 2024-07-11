using Core;
using Entities;
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
        public void UpdateGame(int id, Game game);
        
    }
}
