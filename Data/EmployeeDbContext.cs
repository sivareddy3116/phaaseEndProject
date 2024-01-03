using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmsFullStackApp.Models;

namespace EmsFullStackApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmsFullStackApp.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<EmsFullStackApp.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
