using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
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
              .Include(c => c.GameCategories)
              .ThenInclude(gc => gc.Category)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Platform)
              .Include(c=>c.GameDevelopers)
              .ThenInclude(d=> d.Developer)
              .Include(c=> c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.Language)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.LanguageType)
              .FirstOrDefaultAsync();
            return await game;
        }

        public List<Game> GetGames()
        {
            using ClouxDbContext context = new();
            var games = context.Games
              .Where(c => !c.IsDeleted)
              .Include(c => c.GameCategories)
              .ThenInclude(c=> c.Category)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Platform)
              .Include(c => c.GameDevelopers)
              .ThenInclude(d => d.Developer)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.Language)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.LanguageType)
              .ToList();
            return games;
        }

        public List<Game> GetGamesByPage(int pageNumber, int gamesPerPage)
        {
            using ClouxDbContext context = new();
            var startIndex = (pageNumber - 1) * gamesPerPage;
           
            var games = context.Games
              .Where(c => !c.IsDeleted)
              .OrderByDescending(c => c.DateCreated)
              .ThenByDescending(c => c.Id)
              .Skip(startIndex)
              .Take(gamesPerPage)
              .Include(c => c.GameCategories)
              .ThenInclude(c => c.Category)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Platform)
              .Include(c => c.GameDevelopers)
              .ThenInclude(d => d.Developer)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.Language)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.LanguageType)
              .ToList();
            return games;
        }

        public List<Game> GetFeaturedGames()
        {
            using ClouxDbContext context = new();
            var games = context.Games
              .Where(c => !c.IsDeleted && c.IsFeatured)
              .Include(c => c.GameCategories)
              .ThenInclude(c => c.Category)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Platform)
              .Include(c => c.GameDevelopers)
              .ThenInclude(d => d.Developer)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.Language)
              .Include(c => c.GameLanguageTypeLs)
              .ThenInclude(l => l.LanguageTypeL)
              .ThenInclude(l => l.LanguageType)
              .ToList();
            return games;
        }

        public void UpdateGame(int id, Game game)
        {
            using ClouxDbContext context = new();
            game.Id = id;
            game.DateCreated = DateOnly.FromDateTime(DateTime.Now);


            context.Games.Update(game);
            context.SaveChanges();
        }

        public void AddGame(Game game) { 
        
            using ClouxDbContext context = new();
            context.Games.Add(game);
            context.SaveChanges();
                  
            
           
        }

        public void RemoveGame(int id)
        {
            using ClouxDbContext context = new();
            var deletedGame = context.Games.Where(g => g.Id == id).FirstOrDefault();
            deletedGame.IsDeleted = true;
        }
    }
}
