using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.InternalData.DTO;

public class MarketGetDto
{
    public DateOnly Date { get; init; }
    public int Volume { get; init; }
    public decimal Value { get; init; }
    public decimal Open { get; init; }
    public  decimal Close { get; init; }
    public decimal Low { get; init; }
    public decimal High { get; init; }

    
    public double VolumeComparedToAverage { get; set; }

}
