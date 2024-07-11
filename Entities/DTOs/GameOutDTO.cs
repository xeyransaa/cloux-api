using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GameOutDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<string> CategoryNames { get; set; }
        public virtual List<string> PlatformNames { get; set; }


    }
}
