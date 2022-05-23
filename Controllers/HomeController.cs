using Microsoft.AspNetCore.Mvc;

namespace Back_end_practic1.Controllers
{
    public class HomeController:Controller
    {
        //public ContentResult Index()
        //{
        //    return Content("Hello Ap204");
        //}
        //public JsonResult Index()
        //{
        //    return Json("hello");
        //}
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName="Index";
            return view;
        }
        public ViewResult About()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
        public ActionResult Content(int id)
        {

            ViewBag.product = "Cola";
            ViewData["count"] = 3;
            TempData["type"] = "type";
            return RedirectToAction("About");
            return View();
        }
        public ActionResult Faq(string name,string surname)
        {
            string fullname = $"{name} {surname}";
            return Content(fullname);
        }
    }
}
