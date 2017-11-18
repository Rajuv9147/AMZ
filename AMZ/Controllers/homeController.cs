using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AMZ.Services;

namespace AMZ.Controllers
{
    public class HomeController : Controller
    {
        // GET: BestSeller
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetItems(string itemType)
        {
            return Json(BestSellerService.GetItems(itemType), JsonRequestBehavior.AllowGet);
        }
    }
}