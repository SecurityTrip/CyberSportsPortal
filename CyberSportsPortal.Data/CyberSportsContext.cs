using CyberSportsPortal.Data.Entities;
using CyberSportsPortal.Data.EntityMappings;
using CyberSportsPortal.Data.StaticDataCreators;
using Microsoft.EntityFrameworkCore;

namespace CyberSportsPortal.Data
{
    public class CyberSportsContext : DbContext
    {
        public CyberSportsContext(DbContextOptions<CyberSportsContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentPrize> TournamentPrizes { get; set; }
        public DbSet<TournamentParticipantInfo> TournamentParticipantInfos { get; set; }
        public DbSet<AdvertisingCompany> AdvertisingCompanies { get; set; }
        public DbSet<AdvertisementPaymentInfo> AdvertisementPaymentInfos { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<MatchHistory> MatchHistories { get; set; }
        public DbSet<ProbabilityOfVictory> ProbabilityOfVictories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(PlayerEntityMap).Assembly);
            CreateStaticData(builder);
        }

        private void CreateStaticData(ModelBuilder builder)
        {
            TeamCreator.CreateTeams(builder);
            PlayersCreator.CreatePlayers(builder);
            TournamentsCreator.CreateTournaments(builder);
            TournamentPrizeCreator.CreateTournamentPrizes(builder);
            TournamentParticipantInfoCreator.CreateTournamentParticipantInfos(builder);
            AdvertisingCompaniesCreator.CreateCompanies(builder);
            RatingCreator.CreateRatings(builder);
            MatchHistoryCreator.CreateMatchHistory(builder);
            ProbabilityOfVictoryCreator.CreateProbabilityOfVictory(builder);
        }
    }
}
