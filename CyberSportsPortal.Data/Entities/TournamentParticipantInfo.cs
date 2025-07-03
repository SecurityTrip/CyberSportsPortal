namespace CyberSportsPortal.Data.Entities
{
    public class TournamentParticipantInfo
    {
        public int Id { get; set; }
        public int Standing { get; set; }
        public int? Place { get; set; }
        public int TeamId { get; set; }
        public int TournamentId { get; set; }
        public virtual Team Team { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
