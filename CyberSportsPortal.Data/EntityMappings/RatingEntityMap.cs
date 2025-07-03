using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class RatingEntityMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasOne(x => x.Team)
                .WithMany(x => x.TeamRatings)
                .HasForeignKey(x => x.TeamId);
        }
    }
}