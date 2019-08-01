using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using TuringBackend.Api.Core;

namespace TuringBackend.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseBeatPulse(options =>
                {
                    options.ConfigurePath("health")
                        .ConfigureTimeout(1500) // default -1 infinitely
                        .ConfigureDetailedOutput(true, true); //default (true,false)
                })
                .UseStartup<Startup>()
                .UseLogging();
        }
    }
}