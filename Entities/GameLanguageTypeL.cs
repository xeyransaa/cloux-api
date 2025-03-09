using Core;

namespace Entities
{
    public class GameLanguageTypeL: IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int LanguageTypeLId { get; set; }
        public virtual Game Game { get; set; }
        public virtual LanguageTypeL LanguageTypeL { get; set; }

    }
}