using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using OpenExchange.Infrastructure.DI;

namespace OpenExchange.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(new DependencyInjector().Inject())
                BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
