using BusinessService.Domain.Model;
using System.Linq;

namespace BusinessService.Data.Repositories
{
    public class CourseRepository:Repository<Course>
    {
        private readonly BusinessServiceDbContext context = new BusinessServiceDbContext();
        public void update(int id, Course entities)
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
    }
}
