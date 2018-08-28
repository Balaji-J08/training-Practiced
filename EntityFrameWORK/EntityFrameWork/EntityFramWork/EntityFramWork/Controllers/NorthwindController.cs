using EntityFramWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramWork.Controllers
{
    public class NorthwindController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        public ActionResult Index()
        {
            db.catagoriesTable.ToList();
            db.productTable.ToList();
            return View();
        }
    }
}