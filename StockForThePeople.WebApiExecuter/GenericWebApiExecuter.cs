using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.WebApiExecuter;

public class GenericWebApiExecuter : IWebApiExecuter
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<GenericWebApiExecuter> _logger;

    public string BaseUrl { get; set; } = "";
    public GenericWebApiExecuter(
        ILogger<GenericWebApiExecuter> logger, 
        HttpClient httpClient 
        )
    {
        _httpClient = httpClient;
        _logger = logger;

        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    }
    public async Task<T> InvokeGetAsync<T>(string uri)
    {
        _logger.LogInformation("{var1} - {var2}", nameof(GenericWebApiExecuter), nameof(InvokeGetAsync));

        return await _httpClient.GetFromJsonAsync<T>(GetUrl(uri));
    }

    public async Task<T> InvokePostAsync<T>(string uri, T obj)
    {
        var response = await _httpClient.PostAsJsonAsync(GetUrl(uri), obj);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task InvokePutAsync<T>(string uri, T obj)
    {
        var response = await _httpClient.PutAsJsonAsync(GetUrl(uri), obj);
        response.EnsureSuccessStatusCode();
    }

    public async Task InvokeDeleteAsync(string uri)
    {
        var response = await _httpClient.DeleteAsync(GetUrl(uri));
        response.EnsureSuccessStatusCode();
    }

    private string GetUrl(string uri)
    {
        return $"{BaseUrl}{uri}";
    }

}
