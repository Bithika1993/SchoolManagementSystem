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
            try
            {
                var coursedetails = context.Courses.FirstOrDefault(e => e.CourseId == id);
                return coursedetails;
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
                var courseList = context.Courses.ToList();
                return courseList;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        public Course Add(Course course)
        {
            try
            {
                context.Courses.Add(course);
                context.SaveChanges();
                return null;
            }
            catch(Exception ex) 
            {
                return null;
            }
        }
        public Course update(int id, Course course)
        {
            try
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
            catch(Exception ex)
            {
                return null;
            }
        }
        public Course Delete(int id)
        {
            try
            {
                var coursedetail = context.Courses.FirstOrDefault(e => e.CourseId == id);
                if (coursedetail != null)
                {
                    context.Courses.Remove(coursedetail);
                    context.SaveChanges();
                }
                return coursedetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
