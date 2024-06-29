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
    public class InstructorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InstructorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetInstructors")]
        public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructors()
        {
            var instructorsFromDb = await _context.Instructors.ToListAsync();
            return Ok(instructorsFromDb);
        }

        [HttpGet("{id}", Name = "GetInstructor")]
        public async Task<ActionResult<Instructor>> GetInstructor(int id)
        {
            var instructorFromDb = await _context.Instructors.FindAsync(id);
            if (instructorFromDb == null)
            {
                return NotFound("Instructor not found");
            }
            return Ok(instructorFromDb);
        }

        [HttpPost(Name = "CreateInstructor")]
        public async Task<ActionResult<Instructor>> CreateInstructor([FromBody] Instructor model)
        {
            if (model == null)
            {
                return BadRequest("Instructor data is null");
            }

            if (ModelState.IsValid)
            {
                _context.Instructors.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetInstructor), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateInstructor")]
        public async Task<IActionResult> UpdateInstructor(int id, [FromBody] Instructor model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Instructor data is invalid");
            }

            var instructorFromDb = await _context.Instructors.FindAsync(id);
            if (instructorFromDb == null)
            {
                return NotFound("Instructor not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(instructorFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(instructorFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteInstructor")]
        public async Task<IActionResult> DeleteInstructor(int id)
        {
            var instructorFromDb = await _context.Instructors.FindAsync(id);
            if (instructorFromDb == null)
            {
                return NotFound("Instructor not found");
            }

            _context.Instructors.Remove(instructorFromDb);
            await _context.SaveChangesAsync();
            return Ok("Instructor Deleted");
        }
    }
}