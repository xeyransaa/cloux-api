using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OSReqs: IEntity
    {
        public int Id { get; set; }
        public int OSId { get; set; }
        public int SystemReqsId { get; set; }
        public virtual OS OS {  get; set; }
        public virtual SystemReqs SystemReqs { get; set; }

    }
}
