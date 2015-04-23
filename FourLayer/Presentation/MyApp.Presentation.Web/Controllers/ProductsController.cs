using MyApp.Services.Models;
using MyApp.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Presentation.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.List();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FullProductDTO product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }


        [HttpPost]
        public ActionResult Edit(FullProductDTO product)
        {
            if (ModelState.IsValid)
            {
                _productService.Edit(product);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int id)
        {
            var product = _productService.Get(id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}