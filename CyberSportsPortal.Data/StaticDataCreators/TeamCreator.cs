using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class TeamCreator
    {
        public static void CreateTeams(ModelBuilder builder)
        {
            builder.Entity<Team>().HasData(
                new Team()
                {
                    Id = 1,
                    Name = "Alpha Squad",
                },
                new Team()
                {
                    Id = 2,
                    Name = "Dragon Force",
                },
                new Team()
                {
                    Id = 3,
                    Name = "Polar Bears",
                },
                new Team()
                {
                    Id = 4,
                    Name = "Storm Riders",
                },
                new Team()
                {
                    Id = 5,
                    Name = "Shadow Collective",
                },
                new Team()
                {
                    Id = 6,
                    Name = "Northern Alliance",
                },
                new Team()
                {
                    Id = 7,
                    Name = "Imperial Guard",
                },
                new Team()
                {
                    Id = 8,
                    Name = "Mythic Gaming",
                },
                new Team()
                {
                    Id = 9,
                    Name = "Aurora Esports",
                },
                new Team()
                {
                    Id = 10,
                    Name = "Quantum Gaming",
                },
                new Team()
                {
                    Id = 11,
                    Name = "Frost Giants",
                },
                new Team()
                {
                    Id = 12,
                    Name = "Titan Brigade",
                },
                new Team()
                {
                    Id = 13,
                    Name = "Celestial Team",
                },
                new Team()
                {
                    Id = 14,
                    Name = "Vanguard Esports",
                },
                new Team()
                {
                    Id = 15,
                    Name = "Nebula Warriors",
                },
                new Team()
                {
                    Id = 16,
                    Name = "Omega Team",
                },
                new Team()
                {
                    Id = 17,
                    Name = "Blaze Athletics",
                },
                new Team()
                {
                    Id = 18,
                    Name = "Monsoon Team",
                },
                new Team()
                {
                    Id = 19,
                    Name = "Spectral Gaming",
                },
                new Team()
                {
                    Id = 20,
                    Name = "Horizon Esports",
                }
             );
        }
    }
}
