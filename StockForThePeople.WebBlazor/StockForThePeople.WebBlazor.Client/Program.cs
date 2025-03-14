using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StockForThePeople.WebApiExecuter;
using System.Net.Http.Json;
using System.Runtime;

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
            builder.Services.AddTransient<IWebApiExecuter, GenericWebApiExecuter>();

            var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            Console.WriteLine("Will try to fetch the json file from " + builder.HostEnvironment.BaseAddress);
            StockForThePeopleSettings stockForThePeopleSettings = await httpClient.GetFromJsonAsync<StockForThePeopleSettings>("StockForThePeopleSettings.json");
            builder.Services.AddSingleton(stockForThePeopleSettings);


            await builder.Build().RunAsync();
        }
    }
}
