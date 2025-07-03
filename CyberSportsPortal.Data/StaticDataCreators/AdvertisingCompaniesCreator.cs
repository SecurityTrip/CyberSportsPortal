using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class AdvertisingCompaniesCreator
    {
        public static void CreateCompanies(ModelBuilder builder)
        {
            builder.Entity<AdvertisingCompany>().HasData(
                new AdvertisingCompany()
                {
                    Id = 1,
                    Name = "VeryBigCompany",
                    AdvertisementLink = "videos/Cat.mp4"
                },
                new AdvertisingCompany()
                {
                    Id = 2,
                    Name = "SmallCompany",
                    AdvertisementLink = "videos/Cat2.mp4"
                }
             );
        }
    }
}
