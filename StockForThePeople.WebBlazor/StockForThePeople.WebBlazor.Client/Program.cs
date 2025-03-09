using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StockForThePeople.WebApiExecuter;

namespace StockForThePeople.WebBlazor.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped(sp =>
                new HttpClient
                {});
            builder.Services.AddScoped<IWebApiExecuter, GenericWebApiExecuter>();

            await builder.Build().RunAsync();
        }
    }
}
