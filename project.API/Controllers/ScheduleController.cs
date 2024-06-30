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
    public class ScheduleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetSchedules")]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedules()
        {
            var schedulesFromDb = await _context.Schedules.ToListAsync();
            return Ok(schedulesFromDb);
        }

        [HttpGet("{id}", Name = "GetSchedule")]
        public async Task<ActionResult<Schedule>> GetSchedule(int id)
        {
            var scheduleFromDb = await _context.Schedules.FindAsync(id);
            if (scheduleFromDb == null)
            {
                return NotFound("Schedule not found");
            }
            return Ok(scheduleFromDb);
        }

        [HttpPost(Name = "CreateSchedule")]
        public async Task<ActionResult<Schedule>> CreateSchedule([FromBody] Schedule model)
        {
            if (model == null)
            {
                return BadRequest("Schedule data is null");
            }

            if (ModelState.IsValid)
            {
                _context.Schedules.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetSchedule), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateSchedule")]
        public async Task<IActionResult> UpdateSchedule(int id, [FromBody] Schedule model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Schedule data is invalid");
            }

            var scheduleFromDb = await _context.Schedules.FindAsync(id);
            if (scheduleFromDb == null)
            {
                return NotFound("Schedule not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(scheduleFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(scheduleFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteSchedule")]
        public async Task<IActionResult> DeleteSchedule(int id)
        {
            var scheduleFromDb = await _context.Schedules.FindAsync(id);
            if (scheduleFromDb == null)
            {
                return NotFound("Schedule not found");
            }

            _context.Schedules.Remove(scheduleFromDb);
            await _context.SaveChangesAsync();
            return Ok("Schedule Deleted");
        }
    }
}