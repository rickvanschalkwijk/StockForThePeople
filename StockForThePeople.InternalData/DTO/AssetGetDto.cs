using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.InternalData.DTO;

public class AssetGetDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Ticker { get; set; }

    public string Exchange { get; set; }
    public string Symbol { get; set; }
    public  DateTime Created { get; set; }

    public string Currency { get; set; }
}
