namespace StockForThePeople.WebBlazor.client.DTO;

public class MarketDto
{
    public DateOnly Date { get; set; }
    public decimal Value { get; set; }
    public double Volume { get; set; }
    public double VolumeDeviation { get; set; }
}
