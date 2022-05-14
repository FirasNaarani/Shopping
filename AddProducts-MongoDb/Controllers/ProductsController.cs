using AddProducts_MongoDb.Interface;
using AddProducts_MongoDb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace AddProducts_MongoDb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductServices _context;
        public ProductsController(IProductServices context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.GetAllProducts());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(Products _products,IFormFile image)
        {
            if (image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                image.OpenReadStream().CopyTo(memoryStream);
                _products.image = Convert.ToBase64String(memoryStream.ToArray());
            }
            else
            {
                _products.image = "";
            }

            switch (_products.color)
            {
                case "#000000":
                    _products.color = "Black";
                    break;
                case "#ffffff":
                    _products.color = "White";
                    break;
                case "#ff0000":
                    _products.color = "Red";
                    break;
                case "#00ff00":
                    _products.color = "Green";
                    break;
                case "#0000ff":
                    _products.color = "Blue";
                    break;
                case "#ffff00":
                    _products.color = "Yellow";
                    break;
                case "#ffaa00":
                    _products.color = "Orange";
                    break;
                case "#ff00ff":
                    _products.color = "Pink";
                    break;
                default:
                    _products.color = "NONE";
                    break;
            }

            _context.Create(_products);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
        [HttpPost]
        public IActionResult EditPost(string id, Products _products)
        {
            switch (_products.color)
            {
                case "#000000":
                    _products.color = "Black";
                    break;
                case "#ffffff":
                    _products.color = "White";
                    break;
                case "#ff0000":
                    _products.color = "Red";
                    break;
                case "#00ff00":
                    _products.color = "Green";
                    break;
                case "#0000ff":
                    _products.color = "Blue";
                    break;
                case "#ffff00":
                    _products.color = "Yellow";
                    break;
                case "#ffaa00":
                    _products.color = "Orange";
                    break;
                case "#ff00ff":
                    _products.color = "Pink";
                    break;
                default:
                    _products.color = "NONE";
                    break;
            }

            _context.Update(_products.Id, _products);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var productid = _context.getProductById(id);
            return View(productid);
        }
        [HttpPost]
        public IActionResult DeletePost(string id)
        {
            _context.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
