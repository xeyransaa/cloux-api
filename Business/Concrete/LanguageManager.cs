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
    public class LanguageManager: ILanguageManager
    {
        private readonly ILanguageDal _dal;

        public LanguageManager(ILanguageDal dal)
        {
            _dal = dal;
        }

        public void Add(Language language)
        {
            _dal.Add(language);
        }

        public List<Language> GetAllLanguages()
        {
            return _dal.GetLanguages();
        }

        public void Remove(int id)
        {
            var language = _dal.Get(c => c.Id == id);
            language.IsDeleted = true;
            _dal.Update(language);
        }

        public void Update(int id, Language language)
        {
            _dal.UpdateLanguage(id, language);
        }

        Task<Language> ILanguageManager.GetById(int languageId)
        {
            return _dal.GetById(languageId);
        }
    }
}
