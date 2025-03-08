using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockForThePeople.Data;
using StockForThePeople.ExternalData.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockForThePeople.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhateverController : ControllerBase
    {
        private StockForThePeopleSqliteContext _dbContext;
        public WhateverController(StockForThePeopleSqliteContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<WhateverController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET api/<WhateverController>/5
        [HttpGet("{Ticker}")]
        public async Task<IActionResult> GetAsync(string Ticker)
        {
            Guid id = _dbContext.Assets.Where(x => x.Ticker == Ticker).Select(y => y.Id).FirstOrDefault();
            //Guid id = Guid.Parse(idString);
            var x = await _dbContext.MarketData.Where(x => x.AssetId == id).OrderBy(z => z.Date).ToListAsync();
            return Ok(x);
        }

        // POST api/<WhateverController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WhateverController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WhateverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
