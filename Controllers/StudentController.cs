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
                    await _context.SaveChangesAsync();
                    return BadRequest("Already student exist.");
                }
                else
                {
                    _context.Students.Add(student);
                    await _context.SaveChangesAsync();
                    return Ok("Student added successfully !!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to insert new student.");
                return BadRequest("Failed to insert new student");
            }
        }

        //Update Student data
        //Put :api/students/{id}
        [HttpPut("UpdateStudentData")]
        public async Task<IActionResult> UpdateStudentData([FromBody] Student student)
        {
            try
            {
                _context.Update(student);
                await _context.SaveChangesAsync();
                return Ok("Updated student details  successfully!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to update student details");
                return BadRequest("Failed to update the student details");
            }
        }
        //Update student data by student Id
        [HttpPut("{id}/UpdateStudentByID", Name = "UpdateStudentByID")]
        public async Task<IActionResult> UpdateStudentDataByID(string id,[FromBody] Student updatedStudent)
        {
            try
            {
                var existingStudent = await _context.Students.FindAsync(id);
                if (existingStudent != null)
                {
                    // Update all properties
                    //existingStudent.StudentId = updatedStudent.StudentId;
                    existingStudent.Gender = updatedStudent.Gender;
                    existingStudent.NationalIty = updatedStudent.NationalIty;
                    existingStudent.PlaceofBirth = updatedStudent.PlaceofBirth;
                    existingStudent.StageId = updatedStudent.StageId;
                    existingStudent.GradeId = updatedStudent.GradeId;
                    existingStudent.SectionId = updatedStudent.SectionId;
                    existingStudent.Topic = updatedStudent.Topic;
                    existingStudent.Semester = updatedStudent.Semester;
                    existingStudent.Relation = updatedStudent.Relation;
                    existingStudent.Raisedhands = updatedStudent.Raisedhands;
                    existingStudent.VisItedResources = updatedStudent.VisItedResources;
                    existingStudent.AnnouncementsView = updatedStudent.AnnouncementsView;
                    existingStudent.Discussion = updatedStudent.Discussion;
                    existingStudent.ParentAnsweringSurvey = updatedStudent.ParentAnsweringSurvey;
                    existingStudent.ParentschoolSatisfaction =  updatedStudent.ParentschoolSatisfaction;
                    existingStudent.StudentAbsenceDays = updatedStudent.StudentAbsenceDays;
                    existingStudent.StudentMarks = updatedStudent.StudentMarks;
                    existingStudent.Class = updatedStudent.Class;

                    _context.Update(existingStudent);
                    await _context.SaveChangesAsync();

                    return Ok("Updated student details successfully!");
                }
                else
                {
                    return NotFound("Student not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to update student details");
                return BadRequest("Failed to update the student details");
            }
        }
        // Delete Student data by Id
        [HttpDelete("{id}/deleteStudent", Name = "DeleteStudent")]
        public async Task<IActionResult> DeleteStudentById(string id)
        {
            try
            {
                var findStudent = await _context.Students.FindAsync(id);
                if(findStudent != null)
                {
                    _context.Remove(findStudent);
                    await _context.SaveChangesAsync();
                    return Ok("Deleted student successfully!");
                }
                else{
                    return BadRequest("No such student exists.");
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to delete  student with id: {0}", id);
                return BadRequest("Failed to delete the student");
            }
        }
    }
}
