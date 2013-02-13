﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermarket.DAL;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult RedirectAction(int id,string productAction,int count, string productName)
        {
            //The action depends on the clicked button
            switch (productAction)
            {
                case "Add": ProductDAL.IncreaseProductQuantity(id,count);
                    break;
                case "Delete": ProductDAL.DeleteProduct(id); 
                    break;
                case "Edit":
                    return Edit(id);
                    ;
                    break;
                case "Buy":
                    ;
                    break;
                default:
                    ModelState.AddModelError("","The performed actioned is not allowed!");
                    break;

            }

                TempData["Form"] = Request.Form;

                return RedirectToAction(Request.Form["productAction"].ToString());
            
        }

        //
        // GET: /Product/

        public ActionResult Index()
        {
            List<Product> list = ProductDAL.GetAllProducts();
            List<ProductModelView> productModelViews = new List<ProductModelView>();
            foreach (Product product in list)
            {
                productModelViews.Add(new ProductModelView(product));
            }
            return View(productModelViews);
        }

       
        
        //
        // GET: /Product/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

    
       
    }
}
