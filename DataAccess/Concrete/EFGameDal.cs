using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFGameDal : EFEntityRepositary<ClouxDbContext, Game>, IGameDal
    {
        public async Task<Game> GetById(int id)
        {
            using ClouxDbContext context = new();
            var game = context.Games
              .Where(c => !c.IsDeleted && c.Id == id)
              .Include(c => c.Categories)
              .ThenInclude(c => c.Games)
              .Include(c => c.Platforms)
              .ThenInclude(c => c.Games)
              .FirstOrDefaultAsync();
            return await game;
        }

        public List<Game> GetGames()
        {
            using ClouxDbContext context = new();
            var games = context.Games
              .Where(c => !c.IsDeleted)
              .Include(c => c.Categories)
              .ThenInclude(c=> c.Games)
              .Include(c => c.Platforms)
              .ThenInclude(c => c.Games)
              .ToList();
            return games;
        }

        public List<Game> GetFeaturedGames()
        {
            using ClouxDbContext context = new();
            var games = context.Games
              .Where(c => !c.IsDeleted && c.IsFeatured)
              .Include(c => c.Categories)
              .ThenInclude(c => c.Games)
              .Include(c => c.Platforms)
              .ThenInclude(c => c.Games)
              .ToList();
            return games;
        }

        public void UpdateGame(int id, Game game)
        {
            using ClouxDbContext context = new();
            game.Id = id;
            var singleGame = GetById(id);


            context.Games.Update(game);
            context.SaveChanges();
        }
    }
}
