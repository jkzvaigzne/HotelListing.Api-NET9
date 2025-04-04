using HotelListing.Api.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelListing.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private static List<Hotel> hotels = new List<Hotel>
    {
        new Hotel { Id = 1, Name = "Hotel A", Address = "123 Main St", Rating = 4.5 },
        new Hotel { Id = 2, Name = "Hotel B", Address = "456 Main St", Rating = 4.8 }
    };

    // GET: api/<HotelsController>
    [HttpGet]
    public ActionResult<IEnumerable<Hotel>> Get()
    {
        return Ok(hotels);
    }

    // GET api/<HotelsController>/5
    [HttpGet("{id}")]
    public ActionResult<Hotel>Get(int id)
    {
        var hotel = hotels.FirstOrDefault(h => h.Id == id);
        if (hotel == null)
        {
            return NotFound();
        }

        return Ok(hotel);
    }

    // POST api/<HotelsController>
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<HotelsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<HotelsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
