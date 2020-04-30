using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlCourseRepository
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
        public Course GetCourse(int id)
        {
            var coursedetails = context.Courses.FirstOrDefault(e => e.CourseId == id);
            return coursedetails;
        }
        public IEnumerable<Course> GetAllCourse()
        {
            var courseList = context.Courses.ToList();
            return courseList;

        }
        public Course Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return null;
        }
        public Course update(int id, Course course)
        {
            var coursedetail = context.Courses.FirstOrDefault(e => e.CourseId == id);
            if (coursedetail != null)
            {
                coursedetail.CourseId = course.CourseId;
                coursedetail.CourseName = course.CourseName;
                coursedetail.Description = course.Description;
                context.SaveChanges();
            }
            return coursedetail;
        }
        public Course Delete(int id)
        {
            var coursedetail = context.Courses.FirstOrDefault(e => e.CourseId == id);
            if (coursedetail != null)
            {
                context.Courses.Remove(coursedetail);
                context.SaveChanges();
            }
            return coursedetail;
        }
    }
}
