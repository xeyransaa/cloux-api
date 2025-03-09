using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Language: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual List<LanguageTypeL>? LanguageTypeLs { get; set; }
        public virtual List<GameLanguageTypeL>? GameLanguageTypeLs { get; set; }
      

    }
}
