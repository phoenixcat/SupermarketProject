﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket.DAL
{
   public static class CartDAL
    {
      public static void AddProductToUserCart(aspnet_Users user,Product product,int count)
       {
           SupermarketEntities db = new SupermarketEntities();
           db.AddToUserCarts(new UserCart()
           {
               Product=product,
               aspnet_Users=user,
               Count = count,              

           });
           db.SaveChanges();
       }
           
           
    }
}
