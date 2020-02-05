using System;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanWaterHealth.Model.Domain
{
    public partial class ItemContext : DbContext
    {
        public ItemContext()
        {
        }

        public ItemContext(DbContextOptions<ItemContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Itemauthor> Itemauthor { get; set; }
        public virtual DbSet<Itemfamilygroup> Itemfamilygroup { get; set; }
        public virtual DbSet<Itemglgroup> Itemglgroup { get; set; }
        public virtual DbSet<Itemgowith> Itemgowith { get; set; }
        public virtual DbSet<Itemimage> Itemimage { get; set; }
        public virtual DbSet<Itemnote> Itemnote { get; set; }
        public virtual DbSet<Itemnoteannex> Itemnoteannex { get; set; }
        public virtual DbSet<Itemretailchain> Itemretailchain { get; set; }
        public virtual DbSet<Itemretailchainarchive> Itemretailchainarchive { get; set; }
        public virtual DbSet<Itemsupplier> Itemsupplier { get; set; }

        public virtual DbSet<Itemcolour> Itemcolour { get; set; }
        public virtual DbSet<Itemcolourattrval> Itemcolourattrval { get; set; }
        public virtual DbSet<Itemcolourauthor> Itemcolourauthor { get; set; }
        public virtual DbSet<Itemcolourimage> Itemcolourimage { get; set; }
        public virtual DbSet<Itemcolournote> Itemcolournote { get; set; }
        public virtual DbSet<Itemcolournoteannex> Itemcolournoteannex { get; set; }
        public virtual DbSet<Itemcolourpp> Itemcolourpp { get; set; }
        public virtual DbSet<Itemcolourppics> Itemcolourppics { get; set; }
        public virtual DbSet<Itemcoloursupplier> Itemcoloursupplier { get; set; }
        public virtual DbSet<Itemcoloursysref> Itemcoloursysref { get; set; }


        public virtual DbSet<Itemcoloursize> Itemcoloursize { get; set; }

    }
}
