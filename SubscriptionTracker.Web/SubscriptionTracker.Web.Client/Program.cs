using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SubscriptionTracker.Web.Client.Services;

namespace SubscriptionTracker.Web.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebAssemblyHostBuilder builder =
                WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped<SubscriptionService>();

            await builder.Build().RunAsync();
        }
    }
}