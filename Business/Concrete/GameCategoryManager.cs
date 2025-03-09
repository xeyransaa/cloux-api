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
    public class GameCategoryManager : IGameCategoryManager
    {
        private readonly IGameCategoryDal _dal;

        public GameCategoryManager(IGameCategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(GameCategory gameCategory)
        {
            _dal.Add(gameCategory);
        }

        public void Update(List<int> categoryIds, int gameId)
        {
            _dal.UpdateGameCategory(categoryIds, gameId);
        }
    }
}
