using Core;

namespace Entities
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<GameCategory>? GameCategories { get; set; }
        public bool IsDeleted { get; set; }
    }
}