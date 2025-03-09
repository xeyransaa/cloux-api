using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISocialMediaDal: IEntityRepositary<SocialMedia>
    {
        SocialMedia GetSMbyId(int id);

        List<SocialMedia> GetAllSocialMedia();
        void UpdateLink (int id, SocialMedia socialMedia);
    }
}
