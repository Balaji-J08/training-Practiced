using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramWork.Models
{
    [Table("products")]
    public class product
    {


        [Key]
        public int productID { get; set; }
        public String name { get; set; }
        public decimal price { get; set; }
        public Ctagory catagoryTcatagoryID { get; set; }

    }
}