using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class OrganisationContext : DbContext
    {
        public OrganisationContext()
        {
        }

        public OrganisationContext(DbContextOptions<OrganisationContext> options)
            : base(options)
        {
        }

       
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
