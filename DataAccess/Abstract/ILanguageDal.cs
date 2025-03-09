using Core;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILanguageDal : IEntityRepositary<Language>
    {
        List<Language> GetLanguages();


        Task<Language> GetById(int id);

        public void AddLanguage(Language language);
        public void UpdateLanguage(int id, Language language);
        public void DeleteLanguage(int id);
        
    }
}
