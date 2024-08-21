using Microsoft.AspNetCore.Mvc;

namespace CC10.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        // GET: api/country
        [HttpGet]
        public IActionResult GetCountries()
        {
            // Return a placeholder response
            return Ok("This is the GET method for all countries.");
        }

        // GET: api/country/5
        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            // Return a placeholder response
            return Ok($"This is the GET method for country with ID {id}.");
        }

        // POST: api/country
        [HttpPost]
        public IActionResult CreateCountry([FromBody] string country)
        {
            // Return a placeholder response
            return CreatedAtAction(nameof(GetCountry), new { id = 1 }, country);
        }

        // PUT: api/country/5
        [HttpPut("{id}")]
        public IActionResult UpdateCountry(int id, [FromBody] string country)
        {
            // Return a placeholder response
            return NoContent();
        }

        // DELETE: api/country/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            // Return a placeholder response
            return NoContent();
        }
    }
}
