using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFGameDeveloperDal: EFEntityRepositary<ClouxDbContext, GameDeveloper>, IGameDeveloperDal
    {
        public void Add(GameDeveloper gameDeveloper)
        {
            using ClouxDbContext context = new ClouxDbContext();
            context.GameDevelopers.Add(gameDeveloper);
            context.SaveChanges();
        }

        public void Update(List<int> developerIds, int gameId)
        {
            using ClouxDbContext context = new ClouxDbContext();
            var gameDevelopers = context.GameDevelopers.Where(gd => gd.GameId == gameId).ToList();
            context.GameDevelopers.RemoveRange(gameDevelopers);
            context.SaveChanges();

            foreach (var developerId in developerIds)
            {
                var newGameDeveloper = new GameDeveloper()
                {
                    GameId = gameId,
                    DeveloperId = developerId
                };
                Add(newGameDeveloper);
            }
        }
    }
}
