using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlCourseRepository:Repository<Course>
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
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
            catch (Exception ex)
            {
            }
        }
    }
}
