using System.ComponentModel.DataAnnotations;

namespace BusinessService.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        public string City { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int SchoolId { get; set; }
        [Required]
        public int ClassId { get; set; }
        public School school { get; set; }
        public Course course { get; set; }
        public Class classes { get; set; }
    }
}
