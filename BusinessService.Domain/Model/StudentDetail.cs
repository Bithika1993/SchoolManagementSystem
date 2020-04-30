using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Model
{
    public class StudentDetail
    {
        public Student student { get; set; }
        public School school { get; set; }
        public Course course { get; set; }
    }
}
