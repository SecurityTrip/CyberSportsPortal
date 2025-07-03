using System;
using System.Collections.Generic;

namespace CyberSportsPortal.Data.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organizer { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public virtual ICollection<TournamentParticipantInfo> TeamParticipantInfos { get; set; }
        public virtual ICollection<TournamentPrize> TournamentPrizes { get; set; }
    }
}
