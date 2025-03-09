using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGamePlatformManager
    {
        void Add(GamePlatform gamePlatform);
        void Update(List<int> platformIds, int gameId);
    }
}
