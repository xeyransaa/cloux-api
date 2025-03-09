using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILanguageManager
    {
        void Add(Language language);
        void Update(int id, Language language);
        void Remove(int id);
        Task<Language> GetById(int languageId);
        List<Language> GetAllLanguages();
    }
}
