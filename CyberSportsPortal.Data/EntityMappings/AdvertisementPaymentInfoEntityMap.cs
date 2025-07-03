using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CyberSportsPortal.Data.EntityMappings
{
    public class AdvertisementPaymentInfoEntityMap : IEntityTypeConfiguration<AdvertisementPaymentInfo>
    {
        public void Configure(EntityTypeBuilder<AdvertisementPaymentInfo> builder)
        {
            builder.HasOne(x => x.AdvertisingCompany)
                .WithMany(x => x.AdvertisementPaymentInfos)
                .HasForeignKey(x => x.AdvertisingCompanyId);
        }
    }
}
