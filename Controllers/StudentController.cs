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
        private readonly ILogger<StudentController> _logger;

        public StudentController(StudentDbDemoContext context, ILogger<StudentController> logger)
        {
            _context = context;
            _logger = logger;
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
            catch
            {
                return BadRequest("Error Occured while fetching data");
            }
        }

        // Get: Student by Id
        [HttpGet("GetStudentById")]
        public async Task<IActionResult> GetStudentById(string studentId)
        {
            try
            {
                if (String.IsNullOrEmpty(studentId))
                    return NotFound("Invalid Student ID");

                var student = await _context.Students.FindAsync(studentId);
                if (student == null)
                    return NotFound("No record found for the provided Student ID");

                return Ok(student);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching student by ID.");
                return BadRequest("Internal Server Error Or  Invalid Format of Student ID");
            }
        }

        //Insert Student data record
        //Post : api/students
        [HttpPost("AddNewStudent")]
        public async Task<IActionResult> InsertStudentDataAsync([FromBody] Student student)
        {
            try
            {
                var getstudent = await _context.Students.FindAsync(student.StudentId);
                if (getstudent != null)
                {
                    _context.SaveChanges();
                    return BadRequest("Already student exist.");
                }
                else
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();
                    return Ok("Student added successfully !!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to insert new student.", ex);
                return BadRequest("Failed to insert new student");
            }
        }
    }
}
