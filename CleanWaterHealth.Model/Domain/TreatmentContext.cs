using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class TreatmentContext : DbContext
    {
        public TreatmentContext()
        {
        }

        public TreatmentContext(DbContextOptions<TreatmentContext> options)
            : base(options)
        {
        }             


    }
}
