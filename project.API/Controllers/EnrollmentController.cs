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
    public class EnrollmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetEnrollments")]
        public async Task<ActionResult<IEnumerable<Enrollment>>> GetEnrollments()
        {
            var enrollmentsFromDb = await _context.Enrollments.ToListAsync();
            return Ok(enrollmentsFromDb);
        }

        [HttpGet("{id}", Name = "GetEnrollment")]
        public async Task<ActionResult<Enrollment>> GetEnrollment(int id)
        {
            var enrollmentFromDb = await _context.Enrollments.FindAsync(id);
            if (enrollmentFromDb == null)
            {
                return NotFound("Enrollment not found");
            }
            return Ok(enrollmentFromDb);
        }

        [HttpPost(Name = "CreateEnrollment")]
        public async Task<ActionResult<Enrollment>> CreateEnrollment([FromBody] Enrollment model)
        {
            if (model == null)
            {
                return BadRequest("Enrollment data is null");
            }

            if (ModelState.IsValid)
            {
                _context.Enrollments.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetEnrollment), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateEnrollment")]
        public async Task<IActionResult> UpdateEnrollment(int id, [FromBody] Enrollment model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Enrollment data is invalid");
            }

            var enrollmentFromDb = await _context.Enrollments.FindAsync(id);
            if (enrollmentFromDb == null)
            {
                return NotFound("Enrollment not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(enrollmentFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(enrollmentFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteEnrollment")]
        public async Task<IActionResult> DeleteEnrollment(int id)
        {
            var enrollmentFromDb = await _context.Enrollments.FindAsync(id);
            if (enrollmentFromDb == null)
            {
                return NotFound("Enrollment not found");
            }

            _context.Enrollments.Remove(enrollmentFromDb);
            await _context.SaveChangesAsync();
            return Ok("Enrollment Deleted");
        }
    }
}
