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
        public virtual List <Category>? Categories {  get; set; }
        public virtual List<Platform>? Platforms { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}
