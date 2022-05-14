using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsWebProject.Interface;
using ProductsWebProject.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductServices _context;
        public HomeController(IProductServices context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
           
            return View(_context.GetAllProducts());
        }
        [Route("Search")]
        public IActionResult Search([FromQuery] string title)
        {
            ViewBag.Title = title;  
            return View(_context.Search(title));
        }
        [Route("SearchColor")]
        public IActionResult SearchColor([FromQuery] string myColor)
        {
            switch (myColor)
            {
                case "#000000":
                    ViewBag.Color = "Black";
                    break;
                case "#ffffff":
                    ViewBag.Color = "White";
                    break;
                case "#ff0000":
                    ViewBag.Color = "Red";
                    break;
                case "#00ff00":
                    ViewBag.Color = "Green";
                    break;
                case "#0000ff":
                    ViewBag.Color = "Blue";
                    break;
                case "#ffff00":
                    ViewBag.Color = "Yellow";
                    break;
                case "#ffaa00":
                    ViewBag.Color = "Orange";
                    break;
                case "#ff00ff":
                    ViewBag.Color = "Pink";
                    break;
                default:
                    return StatusCode(404,"Not Found Match");
            }
            return View(_context.SearchColor(ViewBag.Color));
        }
        public IActionResult Details(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
    }
}
