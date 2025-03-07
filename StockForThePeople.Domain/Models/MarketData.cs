using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.Domain.Models;

public class MarketData
{
    public Guid Id { get; set; }

    public Guid AssetId { get; set; }
    public Asset? Asset { get; set; }

    public DateOnly Date { get; set; }

    public int Volume { get; set; }
    public decimal Value { get; set; }
    public decimal Open { get; set; }
    public decimal Close { get; set; }
    public decimal Low { get; set; }
    public decimal High { get; set; }


}
