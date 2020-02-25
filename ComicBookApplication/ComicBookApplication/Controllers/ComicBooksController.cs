using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookApplication.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }

            return Content("Hello from The Comic Books Controller");
      


        }
    }
}
