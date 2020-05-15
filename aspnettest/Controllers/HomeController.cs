using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnettest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //get current UTC time
            DateTime saveUtcNow = DateTime.UtcNow;
            string utcnow = "UTC Now: " + saveUtcNow;

            //set the local Timezone I want to use
            string nzTimeZoneKey = "New Zealand Standard Time";
            TimeZoneInfo nzTimeZone = TimeZoneInfo.FindSystemTimeZoneById(nzTimeZoneKey);

            // convert the UTC time to local timezone value
            DateTime nzDateTime = TimeZoneInfo.ConvertTimeFromUtc(saveUtcNow, nzTimeZone);

            string nznow = "New Zealand Standard Time Now: " + nzDateTime;

            ViewBag.Message = "Time convert test: (1) "+ utcnow+ " (2) " + nznow;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}