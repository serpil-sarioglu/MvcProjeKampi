using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();
        // GET: Istatistik
        public ActionResult Index()
        {
            var result1 = c.Categories.Count();
            var result2 = c.Headings.Count(x => x.Category.CategoryID == 8);
            var result3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            var result4 = c.Headings.Max(x => x.Category.CategoryName);
            var result5 = c.Categories.Count(x => x.CategoryStatus == true);
            var result6 = c.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = result1;
            ViewBag.HeadingCountCategoryID = result2;
            ViewBag.WriterCountCharA = result3;
            ViewBag.MaxHeadingCategoryName = result4;
            ViewBag.DiffCategoryStatus = result5 - result6;
            return View();
        }
    }
}