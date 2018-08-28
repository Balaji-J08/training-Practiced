using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramWork.Models
{
    [Table("catagories")]
    public class Ctagory
    {
        [Key]
        public int catagoryID { get; set; }
        public int catgoryNAME { get; set; }


    }
}