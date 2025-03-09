using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGameDeveloperDal: IEntityRepositary<GameDeveloper>
    {
        void Add(GameDeveloper gameDeveloper);
        void Update(List<int> developerIds, int gameId);
    }
}
