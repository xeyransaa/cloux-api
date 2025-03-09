using Core;

namespace Entities
{
    public class BlogCategory: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}