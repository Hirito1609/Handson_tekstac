using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logging.Controllers
{
    public class HomeController : Controller
    {
        ILog log = LogManager.GetLogger("mylog");
        public ActionResult Index()
        {
            
            log.Info("This is an information message");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            log.Debug("This is a debug message");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            log.Warn("This is a warning message");
            return View();
        }
    }
}