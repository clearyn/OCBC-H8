using System.Threading.Tasks;
using System.Collections.Generic;
//JWT
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Models.DTOs.Requests;
using TodoAppWithJWT.Models.DTOs.Responses;
using TodoAppWithJWT.Data;
using TodoAppWithJWT.Models;


namespace TodoAppWithJWT.Controllers
{   
    [Route("api/[controller]")] // Define routing
    [ApiController] // We need to specify type controller
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]// Login user only aka JWT Auth
    public class TodoController: ControllerBase
    {   
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(new GlobalResponse()
            {   
                Message = new List<string>() {
                        "ResultMessage: " + "Berikut data dari tabel",
                },
                result = items,
                Success = true
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return NotFound();
            
            return Ok(new GlobalResponse()
            {   
                Message = new List<string>() {
                        "ResultMessage: " + "Berikut data dari id yang anda pilih",
                },
                result = item,
                Success = true
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>UpdateItems(int id, ItemData item)
        {
            if (id != item.Id)
                return BadRequest();

            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return  NotFound();

            existItem.Title = item.Title;
            existItem.Description = item.Description;
            existItem.Done = item.Done;

            await _context.SaveChangesAsync();

            return Ok(new GlobalResponse()
            {   
                Message = new List<string>() {
                        "ResultMessage: " + "Berhasil update item",
                },
                Success = true
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return  NotFound();

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(new GlobalResponse()
            {   
                Message = new List<string>() {
                        "ResultMessage: " + "Berikut data id yang dihapus",
                },
                result = existItem,
                Success = true
            });
        }

        // [Route("TestRun")]
        // public ActionResult TestRun()
        // {
        //     return Ok("success");
        // }

    }
}