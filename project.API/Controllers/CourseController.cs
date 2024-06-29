using SchoolActivityApp.Domain.Entities;
using SchoolActivityApp.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SchoolActivityApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetCourses")]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            var coursesFromDb = await _context.Courses.ToListAsync();
            return Ok(coursesFromDb);
        }

        [HttpGet("{id}", Name = "GetCourse")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var courseFromDb = await _context.Courses.FindAsync(id);
            if (courseFromDb == null)
            {
                return NotFound("Course not found");
            }
            return Ok(courseFromDb);
        }

        [HttpPost(Name = "CreateCourse")]
        public async Task<ActionResult<Course>> CreateCourse([FromBody] Course model)
        {
            if (model == null)
            {
                return BadRequest("Course data is null");
            }

            if (ModelState.IsValid)
            {
                _context.Courses.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCourse), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateCourse")]
        public async Task<IActionResult> UpdateCourse(int id, [FromBody] Course model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Course data is invalid");
            }

            var courseFromDb = await _context.Courses.FindAsync(id);
            if (courseFromDb == null)
            {
                return NotFound("Course not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(courseFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(courseFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteCourse")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var courseFromDb = await _context.Courses.FindAsync(id);
            if (courseFromDb == null)
            {
                return NotFound("Course not found");
            }

            _context.Courses.Remove(courseFromDb);
            await _context.SaveChangesAsync();
            return Ok("Course Deleted");
        }
    }
}