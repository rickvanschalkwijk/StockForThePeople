using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.Domain.Models;

public class Asset : BaseModel
{
    [MaxLength(9)]
    public required string Ticker { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(6)]
    public string Symbol { get; set; }
    public string? Type { get; set; }
    public string? Exchange { get; set; }
    public string? Currency { get; set; }




}
