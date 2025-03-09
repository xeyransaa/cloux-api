using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GameInputDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainPhotoUrl { get; set; }
        public string SmallPhotoUrl { get; set; }
        public bool IsFeatured { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> PlatformIds { get; set;}
        public List<int> DeveloperIds { get; set; }
        public List<int> LanguageTypeLIds { get; set; }
        public float OriginalPrice { get; set; }
        public float DiscountedPrice { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public virtual List<int> MinimumOSReqsIds { get; set; }
        public virtual List<int> RecommendedOSReqsIds { get; set; }
        public virtual List<int> AudioLanguagesIds { get; set; }
        public virtual List<int> InterfaceLanguagesIds { get; set; }
        public virtual List<int> SubtitleLanguagesIds { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? FacebookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? GooglePlusLink { get; set; }
        public string? YoutubeLink { get; set; }
        public string? TwitchLink { get; set; }
        public string? InstagramLink { get; set; }


    }
}
