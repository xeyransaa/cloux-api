using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LanguageType: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<LanguageTypeL>? LanguageTypeLs { get; set; }

    }
}
