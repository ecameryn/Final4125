using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final4125.Controllers
{
    public class DTController : Controller
    {
        // GET: DT
        public ActionResult Index()
        {
            return View();
        }

        public String Today()
        {
            DateTime d = DateTime.Now;
            //string date = HttpServerUtility.HtmlEncode(Convert.ToString(d));

            return "Right now is " + d;
        }
    }
}