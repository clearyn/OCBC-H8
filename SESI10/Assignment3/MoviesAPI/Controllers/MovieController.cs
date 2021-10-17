using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MoviesAPIController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MoviesAPIController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var Movie = await _context.Movie.ToListAsync();
            return Ok(Movie);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(MovieData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Movie.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return NotFound();
            
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateItems(int id, MovieData item)
        {
            if (id != item.Id)
                return BadRequest();

            var existItem = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return  NotFound();

            existItem.Name = item.Name;
            existItem.Genre = item.Genre;
            existItem.Duration = item.Duration;
            existItem.ReleaseDate = item.ReleaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Movie.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return  NotFound();

            _context.Movie.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}