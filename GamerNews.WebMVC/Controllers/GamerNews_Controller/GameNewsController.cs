using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerNews.WebMVC.Controllers.GamerNews_Controller
{
    public class GameNewsController : Controller
    {
        // GET: GameNews
        public ActionResult Index()
        {
            return View();
        }
    }
}