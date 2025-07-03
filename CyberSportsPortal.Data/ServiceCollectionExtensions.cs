using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CyberSportsPortal.Data;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, DbSettings dbSettings)
    {
        return services.AddDbContext<CyberSportsContext>((provider, options) => options
        .UseNpgsql(dbSettings.GetConnectionString()));
    }
}