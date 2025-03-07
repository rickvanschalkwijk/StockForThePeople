using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockForThePeople.ExternalData.DTO;

public record DailyMarketDto(
        [property: JsonPropertyName("t")] int timeStampStartOfDay,
        [property: JsonPropertyName("o")] double open,
        [property: JsonPropertyName("h")] double high,
        [property: JsonPropertyName("l")] double low,
        [property: JsonPropertyName("c")] double close,
        [property: JsonPropertyName("v")] int volume,
        [property: JsonPropertyName("a")] double value
    );
