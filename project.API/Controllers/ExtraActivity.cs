using SchoolActivityApp.Domain.Entities;
using SchoolActivityApp.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolActivityApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExtraActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExtraActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetExtraActivities")]
        public async Task<ActionResult<IEnumerable<ExtraActivity>>> GetExtraActivities()
        {
            var extraActivitiesFromDb = await _context.ExtraActivities.ToListAsync();
            return Ok(extraActivitiesFromDb);
        }

        [HttpGet("{id}", Name = "GetExtraActivity")]
        public async Task<ActionResult<ExtraActivity>> GetExtraActivity(int id)
        {
            var extraActivityFromDb = await _context.ExtraActivities.FindAsync(id);
            if (extraActivityFromDb == null)
            {
                return NotFound("Extra activity not found");
            }
            return Ok(extraActivityFromDb);
        }

        [HttpPost(Name = "CreateExtraActivity")]
        public async Task<ActionResult<ExtraActivity>> CreateExtraActivity([FromBody] ExtraActivity model)
        {
            if (model == null)
            {
                return BadRequest("Extra activity data is null");
            }

            if (ModelState.IsValid)
            {
                _context.ExtraActivities.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetExtraActivity), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateExtraActivity")]
        public async Task<IActionResult> UpdateExtraActivity(int id, [FromBody] ExtraActivity model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Extra activity data is invalid");
            }

            var extraActivityFromDb = await _context.ExtraActivities.FindAsync(id);
            if (extraActivityFromDb == null)
            {
                return NotFound("Extra activity not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(extraActivityFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(extraActivityFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteExtraActivity")]
        public async Task<IActionResult> DeleteExtraActivity(int id)
        {
            var extraActivityFromDb = await _context.ExtraActivities.FindAsync(id);
            if (extraActivityFromDb == null)
            {
                return NotFound("Extra activity not found");
            }

            _context.ExtraActivities.Remove(extraActivityFromDb);
            await _context.SaveChangesAsync();
            return Ok("Extra activity Deleted");
        }
    }
}
