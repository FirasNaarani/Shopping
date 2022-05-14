using System.Collections.Generic;
using System.Linq;
using ProductsWebProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductsWebProject.Helpers;
using ProductsWebProject.Interface;
using StoreProducts.Models;

namespace ProductsWebProject.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private readonly IProductServices _context;
        private readonly IMyPurchasesServices _context2;
        public CartController(IProductServices context, IMyPurchasesServices context2)
        {
            _context = context;
            _context2 = context2;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            try
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.price * item.Quantity);
               
            }
            catch
            {
                ViewBag.total = 0;
            }
            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(string id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<Item>();
                cart.Add(new Item { Product = _context.getProductById(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _context.getProductById(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        [Route("myProduct")]
        public IActionResult myProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(MyPurchases _myPurchases)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            float sumPrice= cart.Sum(item => item.Product.price * item.Quantity);
            _myPurchases.products = cart;
            _myPurchases.amount = sumPrice;
            _myPurchases.status = "Pending";
            _context2.Create(_myPurchases);
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }

}
