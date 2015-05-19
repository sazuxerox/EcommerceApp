using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EcommerceApp.Models;

namespace EcommerceApp.DAL
{
    public class EcommerceAppDbContext : DbContext
    {
        public EcommerceAppDbContext()  : base("EcommerceAppDbContext")
        {
            
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
    } 
}