using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Game: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainPhotoUrl { get; set; }
        public string SmallPhotoUrl { get; set; }
        public virtual List <GameCategory>? GameCategories {  get; set; }
        public virtual List<GamePlatform>? GamePlatforms { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public DateOnly DateCreated { get; set; }
        public DateOnly ReleaseDate {  get; set; }
        public float OriginalPrice { get; set; }
        public float DiscountedPrice { get; set; }


        public virtual List<GameDeveloper>? GameDevelopers { get; set; }
        public virtual List<GameLanguageTypeL>? GameLanguageTypeLs { get; set; }
        public virtual List<OSReqs>? MinimumOSReqs { get; set; }
        public virtual List<OSReqs>? RecommendedOSReqs { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? FacebookLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? GooglePlusLink { get; set; }
        public string? YoutubeLink { get; set; }
        public string? TwitchLink { get; set; }
        public string? InstagramLink { get; set; }
      


    }
}
