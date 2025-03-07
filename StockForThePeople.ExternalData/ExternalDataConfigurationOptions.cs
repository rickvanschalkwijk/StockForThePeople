using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.ExternalData;

public sealed class ExternalDataConfigurationOptions
{
    public string ApiToken { get; set; }
    public string BaseUrl { get; set; }
    public string MarketHistoricalDataDailyEndpoint { get; set; }
}
