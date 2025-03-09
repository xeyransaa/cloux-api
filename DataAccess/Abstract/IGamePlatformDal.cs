using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGamePlatformDal: IEntityRepositary<GamePlatform>
    {
        void Add(GamePlatform gamePlatform);
        void Update(List<int> platformIds, int gameId);
    }
}
