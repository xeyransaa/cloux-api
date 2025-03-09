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
    public class EFGamePlatformDal: EFEntityRepositary<ClouxDbContext, GamePlatform>, IGamePlatformDal
    {
        public void Add(GamePlatform gamePlatform)
        {
            using ClouxDbContext context = new ClouxDbContext();
            context.GamePlatforms.Add(gamePlatform);
            context.SaveChanges();
        }

        public void Update(List<int> platformIds, int gameId)
        {
            using ClouxDbContext context = new ClouxDbContext();
            var gamePlatforms = context.GamePlatforms.Where(gp => gp.GameId == gameId).ToList();
            context.GamePlatforms.RemoveRange(gamePlatforms);
            context.SaveChanges();

            foreach (var platformId in platformIds)
            {
                var newGamePlatform = new GamePlatform()
                {
                    GameId = gameId,
                    PlatformId = platformId
                };
                Add(newGamePlatform);
            }
        }
    }
}
