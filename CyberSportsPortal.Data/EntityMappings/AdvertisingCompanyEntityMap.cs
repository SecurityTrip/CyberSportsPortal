using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.Model.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class AdvertisingCompanyEntityMap : IEntityTypeConfiguration<AdvertisingCompany>
    {
        public void Configure(EntityTypeBuilder<AdvertisingCompany> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(DatabaseDefaults.NormalStringMaxLength);
            builder.Property(p => p.AdvertisementLink).IsRequired().HasMaxLength(DatabaseDefaults.NormalStringMaxLength);
        }
    }
}
