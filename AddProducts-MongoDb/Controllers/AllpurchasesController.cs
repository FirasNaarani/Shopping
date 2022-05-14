using AddProducts_MongoDb.Interface;
using AddProducts_MongoDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddProducts_MongoDb.Controllers
{
    public class AllpurchasesController : Controller
    {
        private readonly IMyPurchasesServices _context;
        public AllpurchasesController(IMyPurchasesServices context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.GetAllPurchases());
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
        [HttpPost]
        public IActionResult EditPost(string id, MyPurchases myPurchases)
        {
            _context.Update(myPurchases.Id, myPurchases);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
    }
}
