using CyberSportsPortal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data.StaticDataCreators
{
    public class TournamentParticipantInfoCreator
    {
        public static void CreateTournamentParticipantInfos(ModelBuilder builder)
        {
            builder.Entity<TournamentParticipantInfo>().HasData(
                new TournamentParticipantInfo()
                {
                    Id = 1,
                    Standing = 1,
                    Place = 1,
                    TeamId = 4,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 2,
                    Standing = 2,
                    Place = 2,
                    TeamId = 2,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 3,
                    Standing = 3,
                    Place = 3,
                    TeamId = 5,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 4,
                    Standing = 4,
                    Place = 4,
                    TeamId = 7,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 5,
                    Standing = 5,
                    Place = 5,
                    TeamId = 3,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 6,
                    Standing = 6,
                    Place = 6,
                    TeamId = 14,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 7,
                    Standing = 7,
                    Place = 7,
                    TeamId = 8,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 8,
                    Standing = 8,
                    Place = 8,
                    TeamId = 16,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 9,
                    Standing = 9,
                    Place = 9,
                    TeamId = 9,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 10,
                    Standing = 10,
                    Place = 10,
                    TeamId = 10,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 11,
                    Standing = 11,
                    Place = 11,
                    TeamId = 6,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 12,
                    Standing = 12,
                    Place = 12,
                    TeamId = 1,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 13,
                    Standing = 13,
                    Place = 13,
                    TeamId = 13,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 14,
                    Standing = 14,
                    Place = 14,
                    TeamId = 12,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 15,
                    Standing = 15,
                    Place = 15,
                    TeamId = 15,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 16,
                    Standing = 16,
                    Place = 16,
                    TeamId = 11,
                    TournamentId = 1
                },
                new TournamentParticipantInfo()
                {
                    Id = 17,
                    Standing = 1,
                    Place = 1,
                    TeamId = 11,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 18,
                    Standing = 2,
                    Place = 2,
                    TeamId = 2,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 19,
                    Standing = 3,
                    Place = 3,
                    TeamId = 3,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 20,
                    Standing = 4,
                    Place = 4,
                    TeamId = 16,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 21,
                    Standing = 5,
                    Place = 5,
                    TeamId = 4,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 22,
                    Standing = 6,
                    Place = 6,
                    TeamId = 9,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 23,
                    Standing = 7,
                    Place = 7,
                    TeamId = 15,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 24,
                    Standing = 8,
                    Place = 8,
                    TeamId = 6,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 25,
                    Standing = 9,
                    Place = 9,
                    TeamId = 10,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 26,
                    Standing = 10,
                    Place = 10,
                    TeamId = 20,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 27,
                    Standing = 11,
                    Place = 11,
                    TeamId = 19,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 28,
                    Standing = 12,
                    Place = 12,
                    TeamId = 18,
                    TournamentId = 2
                },
                new TournamentParticipantInfo()
                {
                    Id = 29,
                    Standing = 1,
                    Place = null,
                    TeamId = 2,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 30,
                    Standing = 2,
                    Place = null,
                    TeamId = 20,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 31,
                    Standing = 3,
                    Place = null,
                    TeamId = 3,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 32,
                    Standing = 4,
                    Place = null,
                    TeamId = 15,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 33,
                    Standing = 5,
                    Place = null,
                    TeamId = 6,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 34,
                    Standing = 6,
                    Place = null,
                    TeamId = 14,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 35,
                    Standing = 7,
                    Place = null,
                    TeamId = 16,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 36,
                    Standing = 8,
                    Place = null,
                    TeamId = 8,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 37,
                    Standing = 9,
                    Place = null,
                    TeamId = 4,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 38,
                    Standing = 10,
                    Place = null,
                    TeamId = 5,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 39,
                    Standing = 11,
                    Place = null,
                    TeamId = 7,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 40,
                    Standing = 12,
                    Place = null,
                    TeamId = 13,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 41,
                    Standing = 13,
                    Place = null,
                    TeamId = 9,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 42,
                    Standing = 14,
                    Place = null,
                    TeamId = 10,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 43,
                    Standing = 15,
                    Place = null,
                    TeamId = 19,
                    TournamentId = 3
                },
                new TournamentParticipantInfo()
                {
                    Id = 44,
                    Standing = 16,
                    Place = null,
                    TeamId = 1,
                    TournamentId = 3
                }
            );
        }
    }
}
