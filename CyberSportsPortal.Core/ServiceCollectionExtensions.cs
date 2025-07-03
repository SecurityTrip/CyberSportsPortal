using CyberSportsPortal.Core.Mappers;
using CyberSportsPortal.Core.OlympiadServices;
using CyberSportsPortal.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CyberSportsPortal.Core;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        return services
            .AddScoped<TeamTasksService>()
            .AddScoped<TeamService>()
            .AddScoped<PlayerService>()
            .AddScoped<PlayerMapper>()
            .AddScoped<TournamentService>()
            .AddScoped<TournamentMapper>()
            .AddScoped<TournamentTasksService>()
            .AddScoped<PlayerTasksService>()
            .AddScoped<AdvertisementService>()
            .AddScoped<AdvertisementTasksService>()
            .AddScoped<RatingService>()
            .AddScoped<MatchHistoryService>()
            .AddScoped<TeamMapper>();
    }
}