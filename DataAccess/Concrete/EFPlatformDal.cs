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
    public class EFPlatformDal : EFEntityRepositary<ClouxDbContext, Platform>, IPlatformDal
    {

        public async Task<Platform> GetById(int id)
        {
            using ClouxDbContext context = new();
            var platform = context.Platforms
              .Where(c => !c.IsDeleted && c.Id == id)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Game)
              .FirstOrDefaultAsync();
            return await platform;
        }

        public async Task<Platform> GetByName(string name)
        {
            using ClouxDbContext context = new();
            var platform = context.Platforms
              .Where(c => !c.IsDeleted && c.Name == name)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Game)
              .FirstOrDefaultAsync();
            return await platform;
        }

        public List<Platform> GetPlatforms()
        {
            using ClouxDbContext context = new();
            var platforms = context.Platforms
              .Where(c => !c.IsDeleted)
              .Include(c => c.GamePlatforms)
              .ThenInclude(c => c.Game)
              .ToList();
            return platforms;
        }


        public void UpdatePlatform(int id, Platform platform)
        {
            using ClouxDbContext context = new();
            platform.Id = id;


            context.Platforms.Update(platform);
            context.SaveChanges();
        }

        public void AddPlatform(Platform platform) { 
        
            using ClouxDbContext context = new();
            context.Platforms.Add(platform);
            context.SaveChanges();
                  
            
           
        }

        public void DeletePlatform(int id)
        {
            using ClouxDbContext context = new();
            var deletedPlatform = context.Platforms.Where(g => g.Id == id).FirstOrDefault();
            deletedPlatform.IsDeleted = true;
        }
    }
}
