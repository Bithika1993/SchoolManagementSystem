using System.ComponentModel.DataAnnotations;

namespace BusinessService.Domain.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        public string Description { get; set; }

    }
}
