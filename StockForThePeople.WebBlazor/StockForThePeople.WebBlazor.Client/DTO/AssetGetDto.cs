using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.WebBlazor.client.DTO;

public class AssetGetDto
{
    public Guid Id { get; init; }
    public string Name { get; init;  }
    public string Ticker { get; init; }

    public string Exchange { get; init; }
    public string Symbol { get; init; }
    public  DateTime Created { get; init; }

    public string Currency { get; init; }
}
