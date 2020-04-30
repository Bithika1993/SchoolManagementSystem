using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public int CourseId { get; set; }
        public int SchoolId { get; set; }
        public School school { get; set; }
        public Course course { get; set; }
    }
}
