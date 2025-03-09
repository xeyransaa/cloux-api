using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EFSocialMediaDal : EFEntityRepositary<ClouxDbContext, SocialMedia>, ISocialMediaDal
    {
        public List<SocialMedia> GetAllSocialMedia()
        {
            using ClouxDbContext context = new ClouxDbContext();
            var socialMedia = context.SocialMedia.ToList();

            return socialMedia;
        }

        public SocialMedia GetSMbyId(int id)
        {
            using ClouxDbContext context = new ClouxDbContext();
            var socialMedia = context.SocialMedia.Where(sm => sm.Id == id).FirstOrDefault();

            return socialMedia;
        }

        public void UpdateLink(int id, SocialMedia socialMedia)
        {
            using ClouxDbContext context = new ClouxDbContext();

            socialMedia.Id = id;

            context.SocialMedia.Update(socialMedia);
            context.SaveChanges();
        }
    }
}
