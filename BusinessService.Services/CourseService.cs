using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;

namespace BusinessService.Services
{
    public class CourseService : ICourseRepository
    {
        private readonly CourseRepository sqlCourseRepository = new CourseRepository();
        public void Add(Course entities)
        {
               sqlCourseRepository.Add(entities);
        }

        public void Delete(int Id)
        {
               sqlCourseRepository.Delete(Id);

        }

        public IEnumerable<Course> GetAll()
        {
                var entities = sqlCourseRepository.GetAll();
                return entities;
        }

        public Course Get(int Id)
        {
            try
            {
                var coursedetail = sqlCourseRepository.Get(Id);
                return coursedetail;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Update(int id, Course entities)
        {
                sqlCourseRepository.update(id, entities);
            
        }
    }
}
