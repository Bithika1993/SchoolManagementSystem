﻿using BusinessService.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Data
{
    public class BusinessServiceDbContext  :DbContext
    {      
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> classes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DNETAZ35;Initial Catalog=SchoolManagementSystem;Integrated Security=true");
            optionsBuilder.UseSqlServer("Data Source=tcp:schoolmngsystem.database.windows.net,1433;Initial Catalog=SchoolManagement-DB;Persist Security Info=false;User ID=Bithika.hazra;Password=pass@1234;MultipleActiveResultSets=False;Encrypt=true;TrustServerCertificate=false;Connection Timeout=30");
        }

    }
}
