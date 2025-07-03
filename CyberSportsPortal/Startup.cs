using CyberSportsPortal.Core.Mappers;
using CyberSportsPortal.Core.OlympiadServices;
using CyberSportsPortal.Core.Services;
using CyberSportsPortal.Data;
using CyberSportsPortal.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CyberSportsPortal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var dbSettings = Configuration.GetRequiredSection(nameof(DbSettings)).Get<DbSettings>();
            services.AddDataAccess(dbSettings);

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddAntDesign();
            services.AddScoped<TeamTasksService>();
            services.AddScoped<TeamService>();
            services.AddScoped<PlayerService>();
            services.AddScoped<PlayerMapper>();
            services.AddScoped<TournamentService>();
            services.AddScoped<TournamentMapper>();
            services.AddScoped<TournamentTasksService>();
            services.AddScoped<CountryFlagService>();
            services.AddScoped<PlayerTasksService>();
            services.AddScoped<AdvertisementService>();
            services.AddScoped<AdvertisementTasksService>();
            services.AddScoped<RatingService>();
            services.AddScoped<MatchHistoryService>();
            services.AddScoped<TeamMapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
