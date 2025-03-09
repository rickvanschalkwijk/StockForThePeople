using Microsoft.EntityFrameworkCore;
using StockForThePeople.Data;
using StockForThePeople.InternalData.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.InternalData;

public class InternalDataService : IInternalDataService
{
    private readonly StockForThePeopleSqliteContext _stockForThePeopleSqliteContext;
    public InternalDataService(StockForThePeopleSqliteContext context)
    {
        _stockForThePeopleSqliteContext = context;
    }
    public async Task<List<AssetGetDtoList>> GetAllAssetsAsync()
    {
        List<AssetGetDtoList> returnable = new();
        var domainAssets = _stockForThePeopleSqliteContext.Assets;
        foreach (var asset in domainAssets)
        {
            returnable.Add(new AssetGetDtoList() { 
                Id = asset.Id, 
                Name = asset.Name, 
                Ticker = asset.Ticker });
        }
        return returnable;
    }

    public Task<AssetGetDto> GetAssetByTickerAsync(string ticker)
    {
        var returnable = _stockForThePeopleSqliteContext.Assets.Where(x => x.Ticker == ticker).Select(y => new AssetGetDto()
        {
            Id = y.Id,
            Name = y.Name,
            Ticker = y.Ticker,
            Exchange = y.Exchange,
            Symbol = y.Symbol,
            Currency = y.Currency,
            Created = y.CreatedAt
        }).FirstOrDefaultAsync(); ;
        return returnable;
    }
}
