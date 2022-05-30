using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WGShopping.Entities;

namespace WGShopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly exercise13042020Context _context;

        public ProductController(exercise13042020Context context)
        {
            _context = context;
        }

        // GET: Product
        public IActionResult Index()
        {
            var maxquestions = _context.HangHoas.OrderBy(p => p.MaHh).Take(12).ToList();
            return View(maxquestions);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}