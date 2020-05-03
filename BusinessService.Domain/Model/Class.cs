﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessService.Domain.Model
{
    public class Class
    {
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }
        public string Description { get; set; }
    }
}