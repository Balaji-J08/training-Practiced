using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EntityFramWork.Models
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
        
            :base("name=connection")
        { 

        }
        public DbSet<Ctagory> catagoriesTable { get; set; }
        public DbSet<product> productTable { get; set; }

    }
}