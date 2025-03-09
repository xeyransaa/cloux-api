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
    public class EFGameCategoryDal : EFEntityRepositary<ClouxDbContext, GameCategory>, IGameCategoryDal
    {
        public void AddGameCategory(GameCategory gameCategory)
        {
            using ClouxDbContext context = new ClouxDbContext();

            context.GameCategories.Add(gameCategory);
            context.SaveChanges();
        }

        public void UpdateGameCategory(List<int> categoryIds, int gameId)
        {
            using ClouxDbContext context = new ClouxDbContext();

            var clearedGCategories = context.GameCategories.Where(c => c.GameId == gameId).ToList();

            context.GameCategories.RemoveRange(clearedGCategories);
            context.SaveChanges();
            foreach (var categoryId in categoryIds)
            {
                var newgameCategory = new GameCategory()
                {
                    GameId = gameId,
                    CategoryId = categoryId
                };
                AddGameCategory(newgameCategory);

            }
        }
    }
}
