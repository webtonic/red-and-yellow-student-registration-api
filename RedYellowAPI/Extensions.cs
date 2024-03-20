using Data.Context;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

namespace RedYellowAPI
{
    public static class Extensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // SPA options


            // Managed Identity setup
            //services.Configure<ManagedIdentityOptions>(configuration.GetSection("ManagedIdentity"));
            //services.AddSingleton<IDbAuthTokenProvider, AzureDatabaseTokenProvider>();
            var serverVersion = new MariaDbServerVersion(new Version(8, 0, 36));

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(configuration.GetConnectionString("RedYellowDb"), serverVersion);
                });
 
           

            // Startup background services
          

            // DB Functions
           
            // Auth
          

        }
    }
}
