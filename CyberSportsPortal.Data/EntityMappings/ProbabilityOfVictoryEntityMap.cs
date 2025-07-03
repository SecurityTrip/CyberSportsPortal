using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class ProbabilityOfVictoryEntityMap : IEntityTypeConfiguration<ProbabilityOfVictory>
    {
        public void Configure(EntityTypeBuilder<ProbabilityOfVictory> builder)
        {
            builder.HasOne(x => x.Loser).WithMany().HasForeignKey(x => x.LoserId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Winner).WithMany().HasForeignKey(x => x.WinnerId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}