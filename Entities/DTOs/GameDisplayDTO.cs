using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GameDisplayDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<string> CategoryNames { get; set; }
        public virtual List<string> PlatformNames { get; set; }
        public virtual List<LanguageDisplayDto> LanguageDtos { get; set; }

       

        public string MainPhotoUrl { get; set; }
        public string SmallPhotoUrl { get; set; }
        public string ReleaseMonth { get; set; }
        public int ReleaseDay { get; set; }
        public int ReleaseYear { get; set; }
        public float OriginalPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public List<string> DeveloperNames { get; set; }
        public List<OSReqs> MinimumOSReqs { get; set; }
        public List<OSReqs> RecommendedOSReqs { get; set; }
        public string AdditionalNotes { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string YoutubeLink { get; set; }
        public string TwitchLink { get; set; }
        public string InstagramLink { get; set; }
   


        }
}
