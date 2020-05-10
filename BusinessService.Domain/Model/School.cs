using System.ComponentModel.DataAnnotations;

namespace BusinessService.Domain.Model
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string SchoolType { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
