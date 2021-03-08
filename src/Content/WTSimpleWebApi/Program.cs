using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WTSimpleWebApi.Infrastructure.Extentions;

namespace WTSimpleWebApi
{
    public class Program
    {
        public static void Main(string[] args) => BuildWebHost(args).RunTasks().Run();

        public static IHost BuildWebHost(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
                .ConfigureLogger()
                .Build();
    }
}
