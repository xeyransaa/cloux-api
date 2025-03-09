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
    public class GameLanguageTypeLManager : IGameLanguageTypeLManager
    {
        private readonly IGameLanguageTypeLDal _dal;

        public GameLanguageTypeLManager(IGameLanguageTypeLDal dal)
        {
            _dal = dal;
        }

        public void Add(GameLanguageTypeL gameLanguageTypeL)
        {
            _dal.Add(gameLanguageTypeL);
        }

        public void Update(List<int> languageTypeLIds, int gameId)
        {
            _dal.Update(languageTypeLIds, gameId);
        }
    }
}
