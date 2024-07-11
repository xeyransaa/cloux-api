using Core;

namespace Entities
{
    public class Platform:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Game>? Games { get; set; }
    }
}