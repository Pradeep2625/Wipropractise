using Microsoft.AspNetCore.Mvc;
using LMSApp.Data;
using LMSApp.Models;

namespace LMSApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly LMSContext _context;
        public CourseController(LMSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_context.Courses.ToList());
        }

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCourses), new { id = course.Id }, course);
        }
    }
}
