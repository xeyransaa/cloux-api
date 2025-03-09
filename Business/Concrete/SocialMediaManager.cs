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
    public class SocialMediaManager: ISocialMediaManager
    {
        private readonly ISocialMediaDal _dal;

        public SocialMediaManager(ISocialMediaDal dal)
        {
            _dal = dal;
        }

        public SocialMedia GetSocialMediaById(int id)
        {
            return _dal.GetSMbyId(id);
        }

        public List<SocialMedia> GetSocialMediaList()
        {
            return _dal.GetAllSocialMedia();
        }

        public void UpdateLink(int id, SocialMedia socialMedia)
        {
            _dal.UpdateLink(id, socialMedia);
        }
    }
}
