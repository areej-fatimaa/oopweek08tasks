using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.BL
{
    class Customer:Person
    {
        private string Address;
        private static List<CartItem> cart = new List<CartItem>();
        public Customer(string name,string password,string Address):base(name,password)
        {
            this.Address = Address;
        }
        public Customer(string name, string password) : base(name, password)
        {
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public static void AddToCart(CartItem product)
        {
            cart.Add(product);
        }
        public static List<CartItem> ReturnCart()
        {
            return cart;
        }
        public static  void RemoveFromCart(CartItem product)
        {
            cart.Remove(product);
        }
        public static  float Bill()
        {
           float bill = 0;
           foreach(CartItem cartItem in cart)
            {
                bill = bill + cartItem.GetPrice()*cartItem.GetQuantity();
            }
            return bill;
        }
        public  static void DestroyCart()
        {
            cart.Clear();
        }
    }
}
