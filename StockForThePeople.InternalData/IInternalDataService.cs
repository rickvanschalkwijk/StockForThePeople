using StockForThePeople.InternalData.DTO;

namespace StockForThePeople.InternalData
{
    public interface IInternalDataService
    {
        Task<List<AssetGetDtoList>> GetAllAssetsAsync();
        Task<AssetGetDto> GetAssetByTickerAsync(string ticker);
        Task<AssetWithMarketGetDto> GetMarketForAssetAsync(string ticker);
    }
}