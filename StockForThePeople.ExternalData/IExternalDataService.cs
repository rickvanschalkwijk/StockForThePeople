
namespace StockForThePeople.ExternalData
{
    public interface IExternalDataService
    {
        Task LoadHistoricalDataAsync(int numberOfDays=1000);
        Task UpdateDataAsync(int numberOfDays=30);
    }
}