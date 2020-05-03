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
        public Course Add(Course course)
        {
            try
            {
                if (course != null)
                {
                    var result = sqlCourseRepository.Add(course);
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Course Delete(int Id)
        {
            try
            { 
                var course = sqlCourseRepository.Delete(Id);
                return course;
            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Course> GetAllCourse()
        {
            try
            {
                var course = sqlCourseRepository.GetAllCourse();
                return course;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Course GetCourse(int Id)
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

        public Course Update(int id, Course course)
        {
            try
            {
                var courses = sqlCourseRepository.update(id, course);
                return courses;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}
