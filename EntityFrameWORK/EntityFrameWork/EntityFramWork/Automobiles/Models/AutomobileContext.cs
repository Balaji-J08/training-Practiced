using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Automobiles.Models
{
    public class AutomobileContext: DbContext
    {
        public AutomobileContext()
            : base("name=NorthwindConnection")
        {
            

        }
        public DbSet<Automobiles> AutomobileTable { get; set; }
        public DbSet<vehical> vehicleTable { get; set; }


    }
}