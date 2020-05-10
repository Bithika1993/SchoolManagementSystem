using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService.Tests
{
    public class CourseService :ICourseRepository
    {
        private readonly List<Course> courses;
        public CourseService()
        {
            courses = new List<Course>()
            {
                new Course{ CourseId =1,CourseName="course1",Description="course1"},
                 new Course{CourseId =2,CourseName="course2",Description="course1" },
                  new Course{ CourseId =3,CourseName="course3",Description="course1"},
            };
        }
        public void Add(Course entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Course Get(int Id)
        {
            return courses.FirstOrDefault(a => a.CourseId == Id);
        }

        public IEnumerable<Course> GetAll()
        {
            return courses;
        }

        public void Update(int id, Course entities)
        {
            throw new NotImplementedException();
        }
    }
}
