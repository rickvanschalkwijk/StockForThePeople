using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using StockForThePeople.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.Data;

public class StockForThePeopleSqliteContext : DbContext
{
    public DbSet<Asset> Assets { get; set; }
    public DbSet<MarketData> MarketData { get; set; }
    public DbSet<UserTransaction> UserTransactions { get; set; }

    public StockForThePeopleSqliteContext(DbContextOptions<StockForThePeopleSqliteContext> options) : base(options)
    {
        
    }
}
