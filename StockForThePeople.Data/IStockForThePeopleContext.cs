using Microsoft.EntityFrameworkCore;
using StockForThePeople.Domain.Models;

namespace StockForThePeople.Data
{
    public interface IStockForThePeopleContext
    {
        DbSet<Asset> Assets { get; set; }
        DbSet<MarketData> MarketData { get; set; }
        DbSet<UserTransaction> UserTransactions { get; set; }
    }
}