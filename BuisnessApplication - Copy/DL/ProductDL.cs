using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class ProductDL
    {
        public static List<Product> productList = new List<Product>();
        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public static void DeleteProduct(Product product)
        {
            productList.Remove(product);
        }
        public static void RemoveExpireProducs()
        {
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if ( medicine.GetExpiryDate() <= DateTime.Now)
                {
                    productList.Remove(product);
                }
            }
        }
        
        public static List<Product> ProductToBeOrdered()
        {
            List<Product> productToOrder = new List<Product>();
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if (product.GetStock() < product.GetminQuantity()||medicine.GetExpiryDate()<=DateTime.Now)
                {
                    productToOrder.Add(product);
                }
            }
            return productToOrder;
        }
        public static List<Product> ExpireProducts()
        {
            List<Product> ExpireProducts = new List<Product>();
            foreach (Product product in productList)
            {
                Medicine medicine = (Medicine)product;
                if (medicine.GetExpiryDate() <= DateTime.Now)
                {
                    ExpireProducts.Add(product);
                }
            }
            return ExpireProducts;
        }
        public static void MinimizeStock(List<CartItem> cart)
        {
            int i= 0;
            foreach (CartItem cartItem in cart)
            {
                if(cartItem.Getid()==productList[i].GetID())
                {
                 int newstock  = productList[i].GetStock() - cartItem.GetQuantity();
                    productList[i].SetStock(newstock);
                }
                i++;
            }
        }
    }
}
