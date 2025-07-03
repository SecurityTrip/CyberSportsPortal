using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class TournamentPrizeCreator
    {
        public static void CreateTournamentPrizes(ModelBuilder builder)
        {
            builder.Entity<TournamentPrize>().HasData(
                new TournamentPrize()
                {
                    Id = 1,
                    Place = 1,
                    Prize = 18208300,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 2,
                    Place = 2,
                    Prize = 5202400,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 3,
                    Place = 3,
                    Prize = 3601600,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 4,
                    Place = 4,
                    Prize = 2401100,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 5,
                    Place = 5,
                    Prize = 1400600,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 6,
                    Place = 6,
                    Prize = 1400600,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 7,
                    Place = 7,
                    Prize = 1000500,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 8,
                    Place = 8,
                    Prize = 1000500,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 9,
                    Place = 9,
                    Prize = 800400,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 10,
                    Place = 10,
                    Prize = 800400,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 11,
                    Place = 11,
                    Prize = 800400,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 12,
                    Place = 12,
                    Prize = 800400,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 13,
                    Place = 13,
                    Prize = 600300,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 14,
                    Place = 14,
                    Prize = 600300,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 15,
                    Place = 15,
                    Prize = 600300,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 16,
                    Place = 16,
                    Prize = 600300,
                    TournamentId = 1
                },
                new TournamentPrize()
                {
                    Id = 17,
                    Place = 1,
                    Prize = 175000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 18,
                    Place = 2,
                    Prize = 85000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 19,
                    Place = 3,
                    Prize = 45000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 20,
                    Place = 4,
                    Prize = 25000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 21,
                    Place = 5,
                    Prize = 15000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 22,
                    Place = 6,
                    Prize = 15000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 23,
                    Place = 7,
                    Prize = 10000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 24,
                    Place = 8,
                    Prize = 10000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 25,
                    Place = 9,
                    Prize = 5000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 26,
                    Place = 10,
                    Prize = 5000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 27,
                    Place = 11,
                    Prize = 5000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 28,
                    Place = 12,
                    Prize = 5000,
                    TournamentId = 2
                },
                new TournamentPrize()
                {
                    Id = 29,
                    Place = 1,
                    Prize = 1000000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 30,
                    Place = 2,
                    Prize = 350000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 31,
                    Place = 3,
                    Prize = 2000000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 32,
                    Place = 4,
                    Prize = 150000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 33,
                    Place = 5,
                    Prize = 90000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 34,
                    Place = 6,
                    Prize = 90000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 35,
                    Place = 7,
                    Prize = 90000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 36,
                    Place = 8,
                    Prize = 90000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 37,
                    Place = 9,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 38,
                    Place = 10,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 39,
                    Place = 11,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 40,
                    Place = 12,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 41,
                    Place = 13,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 42,
                    Place = 14,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 43,
                    Place = 15,
                    Prize = 40000,
                    TournamentId = 3
                },
                new TournamentPrize()
                {
                    Id = 44,
                    Place = 16,
                    Prize = 40000,
                    TournamentId = 3
                }
            );
        }
    }
}
