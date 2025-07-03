using CyberSportsPortal.Data.Model.Enums;

namespace CyberSportsPortal.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public Country Country { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
