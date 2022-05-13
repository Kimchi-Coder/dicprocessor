using DicProcessor;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(StartUp))]
namespace DicProcessor;

public class StartUp : IWebJobsStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IWebJobsBuilder builder)
    {
        throw new NotImplementedException();
    }
}