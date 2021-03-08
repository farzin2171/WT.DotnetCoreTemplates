using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WTSimpleWebApi.Infrastructure.Extentions;
using WTSimpleWebApi.Infrastructure.StartupTasks;

namespace WTSimpleWebApi.Infrastructure.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<DataContext>(options =>
            //   options.UseSqlServer(
            //       configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<DataContext>();

            services.AddStartupTask<InformationStartupTask>();
            //services.AddScoped<ILocationService, LocationService>();
            //services.AddScoped<IIdentityService, IdentityService>();
            //services.AddScoped<ICustomerInformationService, CustomerInformationService>();
            //services.AddScoped<IGenerateOrderRefrence, GenerateOrderRefrence>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<IDriverService, DriverService>();

            //services.Decorate<ILocationService, LocationServiceSendMessage>();

            //services.AddHostedService<MessageBrokerPubSubWorker>();
        }
    }
}
