using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGameLanguageTypeLDal : IEntityRepositary<GameLanguageTypeL>
    {
        void Add(GameLanguageTypeL gameLanguageTypeL);
        void Update(List<int> languageTypeLIds, int gameId);
    }
}
