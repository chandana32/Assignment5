using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment5.Models;

namespace Assignment5.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment5.Models.Employee> Employee { get; set; }
    }
}
