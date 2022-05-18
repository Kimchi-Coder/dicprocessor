using DicModels;
using DicProcessor;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.EntityFrameworkCore;

[assembly: WebJobsStartup(typeof(StartUp))]
namespace DicProcessor;

public class StartUp : IWebJobsStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DicContext>();
    }

    public void Configure(IWebJobsBuilder builder)
    {
        throw new NotImplementedException();
    }
    IConfigurationRoot config =
        new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.dev.json", true)
            .AddEnvironmentVariables()
            .Build();
}
