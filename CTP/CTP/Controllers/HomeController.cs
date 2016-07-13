using CTP.Models;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Mvc;

namespace CTP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            ViewBag.BodyClass = "wrapper";
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

    }
}
