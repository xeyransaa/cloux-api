using Core;

namespace Entities
{
    public class Platform:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GamePlatform>? GamePlatforms { get; set; }
        public bool IsDeleted { get; set; }
    }
}