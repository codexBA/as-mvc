using System.Web.Mvc;

namespace AS.MVCFramework.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult General()
        {
            var err = Session["greska"];
            //
            ViewBag.ErrorMessage = 
                err != null 
                ? err.ToString() 
                : "An unexpected error occurred.";
            //
            return View();
        }
    }
}