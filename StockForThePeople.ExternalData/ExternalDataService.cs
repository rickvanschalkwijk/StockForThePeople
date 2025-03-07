using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
using StockForThePeople.ExternalData.DTO;
using StockForThePeople.WebApiExecuter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.ExternalData;

public class ExternalDataService : IExternalDataService
{
    private ILogger<ExternalDataService> _logger;
    private IWebApiExecuter _webApiExecuter;
    private ExternalDataConfigurationOptions _externalDataConfigurationOptions;

    public ExternalDataService(
        ILogger<ExternalDataService> logger,
        IWebApiExecuter webApiExecuter,
        IOptions<ExternalDataConfigurationOptions> options
        )
    {
        _logger = logger;

        _webApiExecuter = webApiExecuter;
        _webApiExecuter.BaseUrl = options.Value.BaseUrl;
        _externalDataConfigurationOptions = options.Value;

    }
    public async Task UpdateDataAsync()
    {
        _logger.LogInformation("Inside the External Data Service");
        var x = await _webApiExecuter.InvokeGetAsync<List<DailyMarketDto>>(_externalDataConfigurationOptions.MarketHistoricalDataDailyEndpoint +
            "TDIV.AS" +
            $"?token={_externalDataConfigurationOptions.ApiToken}" +
            "&start_date=2025-02-01&end_date=2025-03-07");
        _logger.LogInformation("Just one number from the results: {var1}", x[0].value);
    }


}
