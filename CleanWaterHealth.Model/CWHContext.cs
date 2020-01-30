using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanWaterHealth.Model
{
    public class CWHContext : DbContext
    {
        public CWHContext(DbContextOptions<CWHContext> options) : base(options) { }

        public DbSet<Item> Item { get; set; }
     
       
    }
}
