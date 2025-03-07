using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockForThePeople.ExternalData.DTO;

public record DailyReturnEtfDto
(
    [property: JsonPropertyName("daily_return")] double daily_return,
    [property: JsonPropertyName("time")] int time
);
