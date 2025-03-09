using Core;

namespace Entities
{
    public class LanguageTypeL: IEntity
    {
        public int Id { get; set; }
        public int LanguageTypeId { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageType LanguageType { get; set; }
        public virtual Language Language { get; set; }
        public virtual List<GameLanguageTypeL>? GameLanguageTypeLs { get; set; }


    }
}