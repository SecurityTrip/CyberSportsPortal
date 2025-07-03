using CyberSportsPortal.Data.Model.Enums;

namespace CyberSportsPortal.Data.Model.Views
{
    public class PlayerView
    {
        public int Id { get; set; }
        public string CombinedName { get; set; }
        public string NickName { get; set; }
        public Country Country { get; set; }
        public string TeamName { get; set; }
    }
}
