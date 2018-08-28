using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;
 
using System.Web.Mvc;

using System.Data;

using System.Data.SqlClient;
using EntityFramWork.Models;





namespace EntityFramWork.Controllers
{
    public class AutoCompleteController : Controller
    {
        



        public class HomeController : Controller

        {

            //

            // GET: /Home/

            DataBaseAccess.db dblayer = new DataBaseAccess.db();

            public ActionResult Index()

            {

                return View();

            }



            public JsonResult GetRecord(string prefix)

            {

                DataSet ds = dblayer.GetName(prefix);

                List<search> searchlist = new List<search>();

                foreach (DataRow dr in ds.Tables[0].Rows)

                {

                    searchlist.Add(new search
                    {

                        Name = dr["name"].ToString(),

                        id =  dr["id"].ToString()
                        

                    });

                }

                return Json(searchlist, JsonRequestBehavior.AllowGet);

            }

        }

    }




}
