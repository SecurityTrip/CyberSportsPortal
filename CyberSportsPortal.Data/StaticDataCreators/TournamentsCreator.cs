using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class TournamentsCreator
    {
        public static void CreateTournaments(ModelBuilder builder)
        {
            builder.Entity<Tournament>().HasData(
                new Tournament()
                {
                    Id = 1,
                    Name = "World Championship 2024",
                    Organizer = "GameSphere Interactive",
                    StartDate = new DateTimeOffset(2024, 10, 7, 0, 0 ,0, TimeSpan.Zero),
                    EndDate = new DateTimeOffset(2024, 10, 17, 0, 0, 0, TimeSpan.Zero)
                },
                new Tournament()
                {
                    Id = 2,
                    Name = "Elite Series Autumn 2024",
                    Organizer = "Pro Gaming League",
                    StartDate = new DateTimeOffset(2024, 08, 21, 0, 0, 0, TimeSpan.Zero),
                    EndDate = new DateTimeOffset(2024, 08, 29, 0, 0, 0, TimeSpan.Zero)
                },
                new Tournament()
                {
                    Id = 3,
                    Name = "Prime Tournament",
                    Organizer = "Global Esports Network",
                    StartDate = new DateTimeOffset(2026, 3, 1, 0, 0, 0, TimeSpan.Zero),
                    EndDate = new DateTimeOffset(2026, 3, 14, 0, 0, 0, TimeSpan.Zero)
                }
            );
        }
    }
}
