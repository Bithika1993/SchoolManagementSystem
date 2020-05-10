using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace BusinessService.Services
{
    public class StudentService : IStudentRepository
    {       
        private readonly StudentRepository sqlStudentRepository = new StudentRepository();
        private readonly IDistributedCache _cache;
        public StudentService(IDistributedCache cache)
        {
            _cache = cache;
        }
        public void Add(Student entities)
        {
                sqlStudentRepository.Add(entities);
        }
       
        public void Delete(int Id)
        {
                sqlStudentRepository.Delete(Id);
        }

        public IEnumerable<Student> GetAll()
        {
                string Response = _cache.GetString("Student");
                if (string.IsNullOrEmpty(Response))
                {
                    var entitie = sqlStudentRepository.GetAll();
                    Response = JsonSerializer.Serialize<List<Student>>(entitie.ToList());
                    var option = new DistributedCacheEntryOptions();
                    _cache.SetString("Student", Response, option);
                }
                JsonSerializerOptions opt = new JsonSerializerOptions();
                var entities = JsonSerializer.Deserialize<IEnumerable<Student>>(Response, opt);
                return entities;
        }

        public IEnumerable<Student> GetAllStudentsDetails()
        {
                var studentlist = sqlStudentRepository.GetAllStudentsDetails();
                return studentlist;
            
        }
        public IEnumerable<Student> GetStudentsBySchoolId(int id)
        {
                var studentlist = sqlStudentRepository.GetStudentsBySchoolId(id);
                return studentlist;

        }

        public Student Get(int Id)
        {
                var Students = sqlStudentRepository.GetStudentWithAcademicDetails(Id);
                return Students;
        }

        public void Update( int id,Student entities)
        {
                sqlStudentRepository.update(id, entities);
        }
    }
   
 }
