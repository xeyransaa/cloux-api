using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Developer: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GameDeveloper>? GameDevelopers { get; set; }
        public bool IsDeleted { get; set; }
    }
}
