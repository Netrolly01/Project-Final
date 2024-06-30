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
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var studentsFromDb = await _context.Students.ToListAsync();
            return Ok(studentsFromDb);
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var studentFromDb = await _context.Students.FindAsync(id);
            if (studentFromDb == null)
            {
                return NotFound("Student not found");
            }
            return Ok(studentFromDb);
        }

        [HttpPost(Name = "CreateStudent")]
        public async Task<ActionResult<Student>> CreateStudent([FromBody] Student model)
        {
            if (model == null)
            {
                return BadRequest("Student data is null");
            }

            if (ModelState.IsValid)
            {
                _context.Students.Add(model);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetStudent), new { id = model.Id }, model);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}", Name = "UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student model)
        {
            if (model == null || id != model.Id)
            {
                return BadRequest("Student data is invalid");
            }

            var studentFromDb = await _context.Students.FindAsync(id);
            if (studentFromDb == null)
            {
                return NotFound("Student not found");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(studentFromDb).CurrentValues.SetValues(model);
                await _context.SaveChangesAsync();
                return Ok(studentFromDb);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}", Name = "DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var studentFromDb = await _context.Students.FindAsync(id);
            if (studentFromDb == null)
            {
                return NotFound("Student not found");
            }

            _context.Students.Remove(studentFromDb);
            await _context.SaveChangesAsync();
            return Ok("Student Deleted");
        }
    }
}