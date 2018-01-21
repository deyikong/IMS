using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace IMS.DAL
{
    public class IMSContext : DbContext
    {
        public IMSContext() : base("IMSContext")
        {
        }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Currency> Currencies { get; set; }
        public DbSet<Models.Inventory> Inventories { get; set; }
        public DbSet<Models.Item> Items { get; set; }
        public DbSet<Models.ItemPrice> ItemPrices { get; set; }
        public DbSet<Models.Location> Locations { get; set; }
        public DbSet<Models.Price> Prices { get; set; }
        public DbSet<Models.Type> Types { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}