using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEmployes.Entities;

namespace WebApiEmployes
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Departament> Departaments { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Employee> Employee { get; set; }


    }
}
