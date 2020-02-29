using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class AdminContext : DbContext
    {
        public AdminContext()
        {
        }

        public AdminContext(DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }


        public DbSet<Person> Persons { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
