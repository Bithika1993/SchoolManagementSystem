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
        public void Add(Course entities)
        {
            try
            {
                context.Courses.Add(entities);
                context.SaveChanges();
            }
            catch(Exception ex) 
            {
            }
        }
        public void update(int id, Course entities)
        {
            try
            {
                var coursedetail = context.Courses.FirstOrDefault(e => e.CourseId == id);
                if (coursedetail != null)
                {
                    coursedetail.CourseId = entities.CourseId;
                    coursedetail.CourseName = entities.CourseName;
                    coursedetail.Description = entities.Description;
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
            }
        }
        public void Delete(int id)
        {
            try
            {
                var coursedetail = context.Courses.FirstOrDefault(e => e.CourseId == id);
                if (coursedetail != null)
                {
                    context.Courses.Remove(coursedetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
