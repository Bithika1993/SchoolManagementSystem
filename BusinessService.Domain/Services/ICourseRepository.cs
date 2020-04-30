using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface ICourseRepository
    {
        Course GetCourse(int Id);
        Course Add(Course course);
        Course Update(int id, Course course);
        Course Delete(int Id);
        IEnumerable<Course> GetAllCourse();
    }
}
