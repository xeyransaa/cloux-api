using Core;

namespace Entities
{
    public class Author: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string PhotoUrl { get; set; }
        public bool IsDeleted { get; set; }
    }
}