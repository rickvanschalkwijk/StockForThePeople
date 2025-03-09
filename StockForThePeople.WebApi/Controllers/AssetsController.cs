using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [HttpGet]
    public async Task<IActionResult>GetAsync()
    {
        return Ok(await _internalDataService.GetAllAssetsAsync());
    }

    // Get api/<Assets>/Tickercode
    [HttpGet("{ticker}")]
    public async Task<IActionResult> GetByTickerAsync(string ticker)
    {
        return Ok(await _internalDataService.GetAssetByTickerAsync(ticker));
    }


}
