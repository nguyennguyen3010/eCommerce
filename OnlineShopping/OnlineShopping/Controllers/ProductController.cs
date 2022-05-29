using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class ProductController : Controller
    {
        ShoppingEntities model = new ShoppingEntities();

        // GET: Product
        public ActionResult Index()
        {
            var maxquestions = model.HangHoas.OrderBy(p => p.MaHH).Take(12).ToList();
            return View(maxquestions);
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}