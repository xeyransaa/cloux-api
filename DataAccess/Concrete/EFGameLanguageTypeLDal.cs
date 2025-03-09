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
    public class EFGameLanguageTypeLDal : EFEntityRepositary<ClouxDbContext, GameLanguageTypeL>, IGameLanguageTypeLDal
    {
        public void Add(GameLanguageTypeL gameLanguageTypeL)
        {
            using ClouxDbContext context = new ClouxDbContext();
            context.GameLanguageTypeLs.Add(gameLanguageTypeL);
            context.SaveChanges();
        }

        public void Update(List<int> gameLanguageTypeLIds, int gameId)
        {
            using ClouxDbContext context = new ClouxDbContext();
            var gameLanguageTypeLs = context.GameLanguageTypeLs.Where(gp => gp.GameId == gameId).ToList();
            context.GameLanguageTypeLs.RemoveRange(gameLanguageTypeLs);
            context.SaveChanges();

            foreach (var languageTypeLId in gameLanguageTypeLIds)
            {
                var newGameL = new GameLanguageTypeL()
                {
                    GameId = gameId,
                    LanguageTypeLId = languageTypeLId
                };
                Add(newGameL);
            }
        }
    }
}
