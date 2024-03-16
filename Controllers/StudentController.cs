using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbDemoContext _context;
        public StudentController(StudentDbDemoContext context)
        {
            _context = context;
        }
        // GET: api/<StudentController>
        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetStudent()
        {
            try
            {
                var students = await _context.Students.ToListAsync();
                return Ok(students);
            }
            catch{
                return BadRequest("Error Occured while fetching data");
            }
        }
    }
}