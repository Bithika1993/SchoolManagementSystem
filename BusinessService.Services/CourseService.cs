using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Services
{
    public class CourseService : ICourseRepository
    {
        SqlCourseRepository sqlCourseRepository = new SqlCourseRepository();
        public void Add(Course entities)
        {
            try
            {
               sqlCourseRepository.Add(entities);
            }
            catch(Exception ex)
            {
            }
        }

        public void Delete(int Id)
        {
            try
            { 
               sqlCourseRepository.Delete(Id);
            }
            catch(Exception ex)
            {
            }

        }

        public IEnumerable<Course> GetAll()
        {
            try
            {
                var entities = sqlCourseRepository.GetAllCourse();
                return entities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Course Get(int Id)
        {
            try
            {
                var coursedetail = sqlCourseRepository.GetCourse(Id);
                return coursedetail;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Update(int id, Course entities)
        {
            try
            {
                sqlCourseRepository.update(id, entities);
            }
            catch(Exception ex)
            {
            }
            
        }
    }
}
