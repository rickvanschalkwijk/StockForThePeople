using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.InternalData.DTO;

public class AssetGetDtoList
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Ticker { get; set; }
}
