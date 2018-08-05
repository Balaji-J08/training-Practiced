using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Automobiles.Models
{
    public class vehical
    {
        public int id { get; set; }
        public string name { get; set; }
        public String Build_Company { get; set; }
        public Automobiles AutomobilesCatagoryID { get; set; }
    }
}