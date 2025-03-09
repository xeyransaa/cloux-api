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
    public class GameDeveloperManager: IGameDeveloperManager
    {
        private readonly IGameDeveloperDal _dal;

        public GameDeveloperManager(IGameDeveloperDal dal)
        {
            _dal = dal;
        }

        public void Add(GameDeveloper gameDeveloper)
        {
            _dal.Add(gameDeveloper);
        }

        public void Update(List<int> developerIds, int gameId)
        {
            _dal.Update(developerIds, gameId);
        }
    }
}
