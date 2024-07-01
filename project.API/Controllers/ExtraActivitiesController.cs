using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolActivityApp.Domain.Entities;
using SchoolActivityApp.Infrastructure.Context;

namespace SchoolActivityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraActivitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ExtraActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ExtraActivities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtraActivity>>> GetExtraActivities()
        {
            return await _context.ExtraActivities.ToListAsync();
        }

        // GET: api/ExtraActivities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExtraActivity>> GetExtraActivity(int id)
        {
            var extraActivity = await _context.ExtraActivities.FindAsync(id);

            if (extraActivity == null)
            {
                return NotFound();
            }

            return extraActivity;
        }

        // PUT: api/ExtraActivities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraActivity(int id, ExtraActivity extraActivity)
        {
            if (id != extraActivity.Id)
            {
                return BadRequest();
            }

            _context.Entry(extraActivity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtraActivityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExtraActivities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExtraActivity>> PostExtraActivity(ExtraActivity extraActivity)
        {
            _context.ExtraActivities.Add(extraActivity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtraActivity", new { id = extraActivity.Id }, extraActivity);
        }

        // DELETE: api/ExtraActivities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExtraActivity(int id)
        {
            var extraActivity = await _context.ExtraActivities.FindAsync(id);
            if (extraActivity == null)
            {
                return NotFound();
            }

            _context.ExtraActivities.Remove(extraActivity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExtraActivityExists(int id)
        {
            return _context.ExtraActivities.Any(e => e.Id == id);
        }
    }
}
