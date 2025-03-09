using Core;

namespace Entities
{
    public class GameDeveloper: IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int DeveloperId { get; set; }
        public virtual Game Game { get; set; }
        public virtual Developer Developer { get; set; }
    }
}