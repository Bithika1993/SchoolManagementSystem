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
            if (course != null)
            {
                sqlCourseRepository.Add(course);
                return null;
            }
            else
            {
                return null;
            }
        }

        public Course Delete(int Id)
        {
            if (Id != 0)
            {
                var course = sqlCourseRepository.Delete(Id);
                return course;
            }
            else
            {
                return null;
            }

        }

        public IEnumerable<Course> GetAllCourse()
        {
            var course = sqlCourseRepository.GetAllCourse();
            return course;
        }

        public Course GetCourse(int Id)
        {
            var coursedetail = sqlCourseRepository.GetCourse(Id);
            return coursedetail;
        }

        public Course Update(int id, Course course)
        {
            var courses = sqlCourseRepository.update(id, course);
            return courses;
        }
    }
}
