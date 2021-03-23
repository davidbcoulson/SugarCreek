using SugarCreek_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarCreek_BusinessLayer.CartsSupport
{
    public class CartHelper
    {
        public static void CreateCart(Cart cart)
        {
            using (SugarCreekEntities db = new SugarCreekEntities())
            {
                db.Carts.Add(cart);
                db.SaveChanges();

            }

        }

    }
}
