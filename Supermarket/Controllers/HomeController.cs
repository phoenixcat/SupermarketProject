﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermarket.DAL;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Supermarket!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult ViewAllProducts()
        {
            List<Product> list = ProductDAL.GetAllProducts();
            List<ProductModelView> productModelViews = new List<ProductModelView>();
            foreach (Product product in list)
            {
                productModelViews.Add(new ProductModelView(product));
            }
            return View(productModelViews);
        }

        public ActionResult Categories()
        {
            List<Category> list = CategoryDAL.GetAllCategories();
            List<CategoryModelView> categoryModelViews = new List<CategoryModelView>();
            foreach (Category category in list)
            {
                categoryModelViews.Add(new CategoryModelView(category));
            }
            return View(categoryModelViews);
        }
    }
}
