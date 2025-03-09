using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGameCategoryDal: IEntityRepositary<GameCategory>
    {
        void AddGameCategory (GameCategory gameCategory);
        void UpdateGameCategory (List<int> categoryIds, int gameId);
    }
}
