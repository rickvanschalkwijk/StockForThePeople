using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using StockForThePeople.InternalData;

namespace StockForThePeople.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssetsController : ControllerBase
{
    private readonly IInternalDataService _internalDataService;
    public AssetsController(IInternalDataService internalDataService)
    {
        _internalDataService = internalDataService;
    }

    [OutputCache(PolicyName = "Expire300")]
    [HttpGet]
    public async Task<IActionResult>GetAsync()
    {
        return Ok(await _internalDataService.GetAllAssetsAsync());
    }

    // Get api/<Assets>/Tickercode
    [OutputCache(PolicyName = "Expire300")]
    [HttpGet("{ticker}")]
    public async Task<IActionResult> GetByTickerAsync(string ticker)
    {
        return Ok(await _internalDataService.GetAssetByTickerAsync(ticker));
    }

    [OutputCache(PolicyName = "Expire300")]
    [HttpGet("market/{ticker}")]
    public async Task<IActionResult> GetMarketByTickerAsync(string ticker)
    {
        return Ok(await _internalDataService.GetMarketForAssetAsync(ticker));
    }
}
