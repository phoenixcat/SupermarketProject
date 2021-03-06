﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket.DAL
{
   public static class ProductDAL
    {
       public static List<Product> GetAllProducts()
       {
           SupermarketEntities db = new SupermarketEntities();
           List<Product> products = new List<Product>();

           foreach (Product product in db.Products)
           {
               product.Price = Convert.ToDecimal(String.Format("{0:0.00}", product.Price)) ;
               products.Add(product);
           }
           return products;
       }


       public static void IncreaseProductQuantity(int id, int count)
       {
           SupermarketEntities db = new SupermarketEntities();

           db.Products.Where(x => x.ProductId == id).FirstOrDefault().Quantity += count;

           db.SaveChanges();
       }


       public static void DeleteProduct(int id)
       {
            SupermarketEntities db = new SupermarketEntities();

           var product = db.Products.Where(x => x.ProductId == id).FirstOrDefault();

           db.Products.DeleteObject(product);
           db.SaveChanges();
       }
    }
}
