using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISocialMediaManager
    {
        void UpdateLink(int id, SocialMedia socialMedia);
        List<SocialMedia> GetSocialMediaList();
        SocialMedia GetSocialMediaById(int id);
    }
}
