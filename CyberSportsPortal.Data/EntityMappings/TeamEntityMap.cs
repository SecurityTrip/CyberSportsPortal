using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class TeamEntityMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DatabaseDefaults.NormalStringMaxLength);
        }
    }
}
