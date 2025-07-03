using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class TournamentParticipantInfoEntityMap : IEntityTypeConfiguration<TournamentParticipantInfo>
    {
        public void Configure(EntityTypeBuilder<TournamentParticipantInfo> builder)
        {
            builder.HasOne(x => x.Team).WithMany(t => t.TeamTournamentResults).HasForeignKey(x => x.TeamId);
            builder.HasOne(x => x.Tournament).WithMany(t => t.TeamParticipantInfos).HasForeignKey(x => x.TournamentId);
        }
    }
}
