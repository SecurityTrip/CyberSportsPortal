using System;

namespace CyberSportsPortal.Data.Entities
{
    public class MatchHistory
    {
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }
        public int TournamentId { get; set; }
        public DateTimeOffset Date { get; set; }
        public virtual Team Winner { get; set; }
        public virtual Team Loser { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}