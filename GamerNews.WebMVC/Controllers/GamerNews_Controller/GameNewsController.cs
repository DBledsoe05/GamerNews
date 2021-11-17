using GamerNews.Models.Review_Models;
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
            var model = new ReviewListItem[0];
            return View(model);
        }
    }
}