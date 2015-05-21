using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using EcommerceApp.Models;

namespace EcommerceApp.DAL
{
    public class EcommerceAppDbContext : DbContext
    {
        //Specifying the database connection string
        public EcommerceAppDbContext()
            : base("name=EcommerceAppDbContextDatabase")
        {
            
        }

        // These entity will be referred to as the table name
        public DbSet<Category> Categories{ get; set; } 
        public DbSet<Product> Products { get; set; }

        //Preventing database table name from being pluralized
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    } 
}