using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using BusinessService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController()
        {
            _studentRepository = new StudentService();
        }
        [HttpGet]
        [Route("GetStudentWithAcademicDetails/{id}")]
        public IActionResult GetStudentWithAcademicDetails(int id)
        {
            try
            {
                var student = _studentRepository.Get(id);

                if (student != null)
                {
                    return Ok(student);
                }
                else
                {
                    return NotFound(" Student Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetAllStudentPersonalInfo")]
        public IActionResult GetAllStudentPersonalInfo()
        {
            try
            {
                var studentlist = _studentRepository.GetAll();

                if (studentlist.Count() > 0)
                {
                    return Ok(studentlist);
                }
                else
                {
                    return NotFound(" StudentList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllStudentsDetails")]
        public IActionResult GetAllStudentsDetails()
        {
            try
            {
                var studentlist = _studentRepository.GetAllStudentsDetails();

                if (studentlist.Count() > 0)
                {
                    return Ok(studentlist);
                }
                else
                {
                    return NotFound(" StudentList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStudentsBySchoolId/{id}")]
        public IActionResult GetStudentsBySchoolId(int id)
        {
            try
            {
                var studentlist = _studentRepository.GetStudentsBySchoolId(id);

                if (studentlist.Count() > 0)
                {
                    return Ok(studentlist);
                }
                else
                {
                    return NotFound(" StudentList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("addStudent")]
        public IActionResult AddStudent([FromBody]Student student)
        {
            try
            {
               _studentRepository.Add(student);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("updateStudent/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody]Student student)
        {          
            try
            {
               _studentRepository.Update(id, student);
               return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        [HttpDelete]
        [Route("deleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {           
            try
            {
               _studentRepository.Delete(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}