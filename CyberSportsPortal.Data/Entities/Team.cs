using System.Collections.Generic;

namespace CyberSportsPortal.Data.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<TournamentParticipantInfo> TeamTournamentResults { get; set; }
        public virtual ICollection<Rating> TeamRatings { get; set; }
        public virtual ICollection<MatchHistory> MatchesWon { get; set; }
        public virtual ICollection<MatchHistory> MatchesLost { get; set; }
    }
}
