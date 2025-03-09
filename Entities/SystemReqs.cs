using Core;

namespace Entities
{
    public class SystemReqs: IEntity
    {
        public int Id { get; set; }
        public string OS { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string Storage { get; set; }
        public string Graphics { get; set; }
        public string SoundCard { get; set; }



    }
}