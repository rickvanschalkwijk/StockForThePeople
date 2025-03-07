using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StockForThePeople.ExternalData;
using StockForThePeople.ExternalData.DTO;
using StockForThePeople.WebApiExecuter;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockForThePeople.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToBeRemovedController : ControllerBase
    {
        private IExternalDataService _externalDataService;
        private ILogger<ToBeRemovedController> _logger;
        public ToBeRemovedController(
            IExternalDataService externalDataService,
            ILogger<ToBeRemovedController> logger
            )
        {
            _logger = logger;
            _externalDataService = externalDataService;
            
        }
        // GET: api/<ToBeRemovedController>
        [HttpGet]
        public async Task<IActionResult> UpdateDataAsync()
        {
            _logger.LogInformation("Calling the service.");
            await _externalDataService.UpdateDataAsync(); //I should probably not await here.
            _logger.LogInformation("Ending the servicecall.");
            return Ok("Updating data...");
            

        }

        // GET api/<ToBeRemovedController>/5
        [HttpGet("{id}")]
        //public string Get(int id)
        public async Task<IActionResult> Get(int id)
        {
            return Ok("value");
        }

        // POST api/<ToBeRemovedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToBeRemovedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToBeRemovedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
