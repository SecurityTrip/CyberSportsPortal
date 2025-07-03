using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class TournamentPrizeEntityMap : IEntityTypeConfiguration<TournamentPrize>
    {
        public void Configure(EntityTypeBuilder<TournamentPrize> builder)
        {
            builder.HasOne(x => x.Tournament).WithMany(x => x.TournamentPrizes).HasForeignKey(x => x.TournamentId);
        }
    }
}
