using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class TournamentEntityMap : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(DatabaseDefaults.NormalStringMaxLength);
            builder.Property(x => x.Organizer).IsRequired().HasMaxLength(DatabaseDefaults.NormalStringMaxLength);
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
        }
    }
}
