using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFLanguageDal : EFEntityRepositary<ClouxDbContext, Language>, ILanguageDal
    {

        public async Task<Language> GetById(int id)
        {
            using ClouxDbContext context = new();
            var language = context.Languages
              .Where(c => !c.IsDeleted && c.Id == id)
              .FirstOrDefaultAsync();
            return await language;
        }

        public List<Language> GetLanguages()
        {
            using ClouxDbContext context = new();
            var languages = context.Languages
              .Where(c => !c.IsDeleted)
              .ToList();
            return languages;
        }


        public void UpdateLanguage(int id, Language language)
        {
            using ClouxDbContext context = new();
            language.Id = id;


            context.Languages.Update(language);
            context.SaveChanges();
        }

        public void AddLanguage(Language language) { 
        
            using ClouxDbContext context = new();
            context.Languages.Add(language);
            context.SaveChanges();
                  
            
           
        }

        public void DeleteLanguage(int id)
        {
            using ClouxDbContext context = new();
            var deletedLanguage = context.Languages.Where(g => g.Id == id).FirstOrDefault();
            deletedLanguage.IsDeleted = true;
        }
    }
}
