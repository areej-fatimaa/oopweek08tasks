using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class ProductValidation
    {
        public static bool IsValidQuantity(int quantity)
        {
            try
            {
                if (quantity >= 0 && quantity <= 10)
                {
                    return true;
                }
                else
                {
                    throw new ArgumentException("Quantity must be between 0 and 10.");
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool CheckProduct(string ID)
        {
            foreach(Product product in ProductDL.productList)
            {
                if(product.GetID()==ID)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Checknull(string attribute)
        {
            if(attribute=="")
            {
                return false;
            }
            return true;
        }
        public static Product ReturnProduct(string id)
        {
            foreach(Product product in ProductDL.productList)
            {
                if(product.GetID()==id)
                {
                    return product;
                }
            }
            return null;
        }
        public static CartItem ReturnProductFromCart(string id,List<CartItem>cart)
        {
            foreach (CartItem cartItem in cart)
            {
                if (cartItem.GetName() == id)
                {
                    return cartItem;
                }
            }
            return null;
        }
    }
}
