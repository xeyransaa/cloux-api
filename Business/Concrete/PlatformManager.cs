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
    public class PlatformManager: IPlatformManager
    {
        private readonly IPlatformDal _dal;

        public PlatformManager(IPlatformDal dal)
        {
            _dal = dal;
        }

        public void Add(Platform platform)
        {
            _dal.Add(platform);
        }

        public List<Platform> GetAllPlatforms()
        {
            return _dal.GetPlatforms();
        }

        public Task<Platform> GetByName(string platformName)
        {
            return _dal.GetByName(platformName);
        }

        public void Remove(int id)
        {
            var platform = _dal.Get(c => c.Id == id);
            platform.IsDeleted = true;
            _dal.Update(platform);
        }

        public void Update(int id, Platform platform)
        {
            _dal.UpdatePlatform(id, platform);
        }

        Task<Platform> IPlatformManager.GetById(int platformId)
        {
            return _dal.GetById(platformId);
        }
    }
}
