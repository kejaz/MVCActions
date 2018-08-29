using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActions.Controllers
{
    public class HomeController : Controller
    {

        // ******** Action Selection **************
        //[ActionName("List")]
        public ViewResult Index()
        {
            //return "<h1>Index() action method invoked</h1>";
            return View();
            //return View("Index");
        }

        public ActionResult MyNewView()
        {
            return PartialView();
        }
        // ******** Non Action Attribute **************        
        //[NonAction]
        //private string Method1()
        //{
        //    return "<h1>Method1() action method invoked</h1>";
        //}

        //public string Method2()
        //{
        //    return "<h1>Method2 action method invoked</h1>";
        //}


        // ******** Action Filters Attribute **************        
        // **** [Authorize], [ChildActionOnly], [HandleError], [OutputCache], [ValidateInput]

        //[Authorize], [AllowAnonymouse]
        //public ActionResult SecureMethod()
        //{
        //    return View();
        //}
        //public ActionResult NonSecureMethod()
        //{
        //    return View();
        //}

        //*******[ChildActionOnly] ******
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //[ChildActionOnly]
        //public ActionResult Names(List<string> names)
        //{
        //    return View(names);
        //}

        //************* [HandleError] ********** 
        //[HandleError]
        //public ActionResult TestMethod()
        //{
        //    throw new Exception("Somthing went wrong");
        //}

        //************ Output Cache *********
        //[OutputCache(Duration = 5)]
        //public string GetCurrentTime()
        //{
        //    return DateTime.Now.ToLongTimeString();
        //}

        //************ Validation Filter *********
        //public ActionResult GetResult()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public string GetResult(string comments)
        //{
        //    return "Your comments " + comments;
        //}

        //********** ActionResult  sub classes 
        public ViewResult MyView()
        {
            return View();
        }
        public JsonResult MyJson()
        {
            return Json(new { ID = 01, Name = "Admin" }, JsonRequestBehavior.AllowGet);
        }
        public RedirectToRouteResult MyRedirect()
        {
            return RedirectToAction("Index");
        }
    }
}