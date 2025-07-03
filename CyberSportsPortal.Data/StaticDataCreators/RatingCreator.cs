using System;
using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class RatingCreator
    {
        public static void CreateRatings(ModelBuilder builder)
        {
            builder.Entity<Rating>().HasData(
                new Rating()
                {
                    Id = 1,
                    TeamId = 1,
                    Score = 500,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 2,
                    TeamId = 2,
                    Score = 1000,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 3,
                    TeamId = 3,
                    Score = 750,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 4,
                    TeamId = 4,
                    Score = 600,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 5,
                    TeamId = 5,
                    Score = 900,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 6,
                    TeamId = 6,
                    Score = 650,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 7,
                    TeamId = 7,
                    Score = 850,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 8,
                    TeamId = 8,
                    Score = 800,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 9,
                    TeamId = 9,
                    Score = 300,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 10,
                    TeamId = 10,
                    Score = 678,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 11,
                    TeamId = 11,
                    Score = 489,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 12,
                    TeamId = 12,
                    Score = 721,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 13,
                    TeamId = 13,
                    Score = 578,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 14,
                    TeamId = 14,
                    Score = 846,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 15,
                    TeamId = 15,
                    Score = 728,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 16,
                    TeamId = 16,
                    Score = 564,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 17,
                    TeamId = 17,
                    Score = 279,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 18,
                    TeamId = 18,
                    Score = 176,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 19,
                    TeamId = 19,
                    Score = 228,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                },
                new Rating()
                {
                    Id = 20,
                    TeamId = 20,
                    Score = 80,
                    AtMoment = new DateTimeOffset(2021, 10, 1, 0, 0, 0, TimeSpan.Zero)
                }
            );
        }
    }
}