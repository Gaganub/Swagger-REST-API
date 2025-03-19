using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Course = "Data Science" },
            new Student { Id = 2, Name = "Bob", Course = "Machine Learning" }
        };

        // GET: api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }

        // GET: api/students/1
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return student != null ? Ok(student) : NotFound("Student not found");
        }

        // POST: api/students
        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student newStudent)
        {
            newStudent.Id = students.Count + 1;
            students.Add(newStudent);
            return CreatedAtAction(nameof(GetStudent), new { id = newStudent.Id }, newStudent);
        }

        // PUT: api/students/1
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.Course = updatedStudent.Course;
            return Ok(student);
        }

        // DELETE: api/students/1
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound("Student not found");

            students.Remove(student);
            return Ok("Student deleted");
        }
    }
}
