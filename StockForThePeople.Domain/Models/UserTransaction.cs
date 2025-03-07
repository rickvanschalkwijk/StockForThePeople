using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.Domain.Models;

public class UserTransaction : BaseModel
{
    public Guid UserId { get; set; }

    [MaxLength(1)]
    public string Type { get; set; }
    public int Units { get; set; }
    public DateTime? TransactionMoment { get; set; }

    public required Guid AssetId { get; set; }
    public Asset? Asset { get; set; }

    public required decimal UnitPrice { get; set; }

}
