using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class MatchHistoryCreator
    {
        public static void CreateMatchHistory(ModelBuilder builder)
        {
            builder.Entity<MatchHistory>().HasData(
                new MatchHistory()
                {
                    Id = 1,
                    WinnerId = 2,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 2,
                    WinnerId = 4,
                    LoserId = 3,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 3,
                    WinnerId = 5,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 4,
                    WinnerId = 7,
                    LoserId = 8,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 5,
                    WinnerId = 9,
                    LoserId = 10,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 6,
                    WinnerId = 12,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 7,
                    WinnerId = 14,
                    LoserId = 13,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 8,
                    WinnerId = 15,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 7, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 9,
                    WinnerId = 3,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 10,
                    WinnerId = 4,
                    LoserId = 2,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 11,
                    WinnerId = 7,
                    LoserId = 5,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 12,
                    WinnerId = 8,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 13,
                    WinnerId = 9,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 14,
                    WinnerId = 10,
                    LoserId = 12,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 15,
                    WinnerId = 15,
                    LoserId = 13,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 16,
                    WinnerId = 14,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 8, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 17,
                    WinnerId = 5,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 18,
                    WinnerId = 2,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 19,
                    WinnerId = 7,
                    LoserId = 3,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 20,
                    WinnerId = 4,
                    LoserId = 8,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 21,
                    WinnerId = 9,
                    LoserId = 13,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 22,
                    WinnerId = 14,
                    LoserId = 10,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 23,
                    WinnerId = 15,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 24,
                    WinnerId = 16,
                    LoserId = 12,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 9, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 25,
                    WinnerId = 4,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 26,
                    WinnerId = 2,
                    LoserId = 3,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 27,
                    WinnerId = 5,
                    LoserId = 8,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 28,
                    WinnerId = 7,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 29,
                    WinnerId = 9,
                    LoserId = 12,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 30,
                    WinnerId = 10,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 31,
                    WinnerId = 13,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 32,
                    WinnerId = 15,
                    LoserId = 14,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 10, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 33,
                    WinnerId = 1,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 34,
                    WinnerId = 2,
                    LoserId = 7,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 35,
                    WinnerId = 3,
                    LoserId = 8,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 36,
                    WinnerId = 4,
                    LoserId = 5,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 37,
                    WinnerId = 9,
                    LoserId = 14,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 38,
                    WinnerId = 10,
                    LoserId = 15,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 39,
                    WinnerId = 11,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 40,
                    WinnerId = 12,
                    LoserId = 13,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 11, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 41,
                    WinnerId = 7,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 42,
                    WinnerId = 2,
                    LoserId = 8,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 43,
                    WinnerId = 5,
                    LoserId = 3,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 44,
                    WinnerId = 4,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 45,
                    WinnerId = 15,
                    LoserId = 9,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 46,
                    WinnerId = 10,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 47,
                    WinnerId = 13,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 48,
                    WinnerId = 14,
                    LoserId = 12,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 12, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 49,
                    WinnerId = 8,
                    LoserId = 1,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 50,
                    WinnerId = 2,
                    LoserId = 5,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 51,
                    WinnerId = 3,
                    LoserId = 6,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 52,
                    WinnerId = 4,
                    LoserId = 7,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 53,
                    WinnerId = 9,
                    LoserId = 16,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 54,
                    WinnerId = 10,
                    LoserId = 13,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 55,
                    WinnerId = 14,
                    LoserId = 11,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 56,
                    WinnerId = 15,
                    LoserId = 12,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 13, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 57,
                    WinnerId = 2,
                    LoserId = 10,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 15, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 58,
                    WinnerId = 4,
                    LoserId = 14,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 15, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 59,
                    WinnerId = 9,
                    LoserId = 5,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 15, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 60,
                    WinnerId = 7,
                    LoserId = 15,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 15, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 61,
                    WinnerId = 9,
                    LoserId = 7,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 16, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 62,
                    WinnerId = 4,
                    LoserId = 2,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 16, 0, 0, 0, TimeSpan.Zero)
                },
                new MatchHistory()
                {
                    Id = 63,
                    WinnerId = 4,
                    LoserId = 9,
                    TournamentId = 1,
                    Date = new DateTimeOffset(2021, 10, 17, 0, 0, 0, TimeSpan.Zero)
                }
            );
        }
    }
}