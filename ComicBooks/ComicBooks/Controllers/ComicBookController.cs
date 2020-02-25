using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBooks.Controllers
{
    public class ComicBookController : Controller
    {
       
        public ActionResult Detail()
        {


            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>In this issue spider man is consumed by a dark viscious liquid...... <strong>Could it mean Venom is coming back<strong></p>";
            ViewBag.Artists = new string[] {
                "Script: Dan Middleton",
                "Pencils: Shikparak Singh",
                "Inks: Victor Shabalala",
                "Colors: Mbali Shozi",
                "Letters: Shareek Parker" };

            return View();
        }
    }
}