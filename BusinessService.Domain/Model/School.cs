using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Model
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
