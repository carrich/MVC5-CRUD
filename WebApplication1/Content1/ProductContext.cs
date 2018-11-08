using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Content1
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}