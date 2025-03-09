using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GamePlatformManager: IGamePlatformManager
    {
        private readonly IGamePlatformDal _dal;

        public GamePlatformManager(IGamePlatformDal dal)
        {
            _dal = dal;
        }

        public void Add(GamePlatform gamePlatform)
        {
            _dal.Add(gamePlatform);
        }

        public void Update(List<int> platformIds, int gameId)
        {
            _dal.Update(platformIds, gameId);
        }
    }
}
