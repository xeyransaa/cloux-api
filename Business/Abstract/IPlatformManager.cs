using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlatformManager
    {
        void Add(Platform platform);
        void Update(int id, Platform platform);
        void Remove(int id);
        Task<Platform> GetById(int platformId);
        Task<Platform> GetByName(string platformName);
        List<Platform> GetAllPlatforms();
    }
}
