using Core;

namespace Entities
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Game>? Games { get; set; }
    }
}