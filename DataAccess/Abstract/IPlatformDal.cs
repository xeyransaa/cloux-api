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
    public interface IPlatformDal : IEntityRepositary<Platform>
    {
        List<Platform> GetPlatforms();


        Task<Platform> GetById(int id);
        Task<Platform> GetByName(string name);

        public void AddPlatform(Platform platform);
        public void UpdatePlatform(int id, Platform platform);
        public void DeletePlatform(int id);
        
    }
}
