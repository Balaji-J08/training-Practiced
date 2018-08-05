using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Automobiles.Models;

namespace Automobiles.Controllers
{
    public class AutomobileController : Controller
    {
        AutomobileContext ac = new AutomobileContext();

        public ActionResult Index()
        {
            ac.AutomobileTable.ToList();
            ac.vehicleTable.ToList();


            return View();
        }
    }
}