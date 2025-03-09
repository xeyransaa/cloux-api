using Core;

namespace Entities
{
    public class GameCategory: IEntity
    {
        public int Id { get; set; }
        public int GameId {  get; set; }

        public virtual Game Game { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}