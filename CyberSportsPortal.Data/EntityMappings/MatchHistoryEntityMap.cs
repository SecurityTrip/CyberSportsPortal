using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class MatchHistoryEntityMap : IEntityTypeConfiguration<MatchHistory>
    {
        public void Configure(EntityTypeBuilder<MatchHistory> builder)
        {
            builder.HasOne(x => x.Loser).WithMany(x => x.MatchesLost).HasForeignKey(x => x.LoserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Winner).WithMany(x => x.MatchesWon).HasForeignKey(x => x.WinnerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Tournament).WithMany().HasForeignKey(x => x.TournamentId);
        }
    }
}