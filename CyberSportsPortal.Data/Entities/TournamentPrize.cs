namespace CyberSportsPortal.Data.Entities
{
    public class TournamentPrize
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int Prize { get; set; }
        public int TournamentId { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
