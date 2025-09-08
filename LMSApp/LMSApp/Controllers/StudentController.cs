using Microsoft.AspNetCore.Mvc;
using LMSApp.Data;
using LMSApp.Models;

namespace LMSApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly LMSContext _context;
        public StudentController(LMSContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.Students.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }
    }
}
