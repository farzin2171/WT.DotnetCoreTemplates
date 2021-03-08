using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WTSimpleWebApi.Infrastructure.Installers
{
    public class AutoMapperInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(Startup));
        }
    }
}
