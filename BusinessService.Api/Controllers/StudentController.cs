using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student Get(int id)
        {
           var student= _studentRepository.GetStudent(id);
            return student;

        }
        public IEnumerable<Student> GetAllStudent()
        {
            var studentlist= _studentRepository.GetAllStudent();
            return studentlist;

        } 
        public HttpResponseMessage Post(Student student)
        {
            try
            {
               _studentRepository.Add(student);
                return null;
               
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HttpResponseMessage Put(int id,Student student)
        {
            _studentRepository.Update(id,student);
            return null;           
        } 
        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }



    }
}