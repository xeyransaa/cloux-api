using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGameCategoryManager
    {
        void Add(GameCategory gameCategory);
        void Update(List<int> categoryIds, int gameId);
    }
}
