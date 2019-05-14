using ClassLibrary1;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using MyApp;

[assembly: FunctionsStartup(typeof(Startup))]
namespace MyApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddApplication();
        }
    }
}