using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class WardContext : DbContext
    {
        public WardContext()
        {
        }

        public WardContext(DbContextOptions<WardContext> options)
            : base(options)
        {
        }             

    }
}
