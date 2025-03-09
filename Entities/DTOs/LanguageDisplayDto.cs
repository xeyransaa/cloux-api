using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class LanguageDisplayDto
    {
        public string Name { get; set; }
        public virtual List<string> GameLanguageTypes { get; set; }
    }
}
