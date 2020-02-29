using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class StaffContext : DbContext
    {
        public StaffContext()
        {
        }

        public StaffContext(DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Doctor> Doctors{ get; set; }

    }
}
