using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.UI
{
    class CustomerUI
    {
        public static void ViewProducts(List<Product> productList)
        {
            foreach (Product product in productList)
            {
                if (product is Medicine)
                {
                    Console.WriteLine("ID\tName\t\tDosageForm\t\tStrength\t\tManufacturing Date\t\tExpiry Date\t\tPrice\t\tMinStock\t\tStock");
                }
                if (product is Equipments)
                {
                    Console.WriteLine("ID\t\tName\t\tWarrenty\t\t\tPrice\t\tMinStock\t\tStock");
                }
                Console.WriteLine(product.ToString() );
              
            }
            Console.ReadKey();
        }
        public static void ViewEquipmentsOnly(List<Product> productList)
        {
            Console.WriteLine("ID\t\tName\t\tWarrenty\t\tPrice\t\tMinStock\t\tStock");
            foreach (Product product in productList)
            {
                if (product is Equipments)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            Console.ReadKey();
        }
        public static void ViewMedicinesOnly(List<Product> productList)
        {
            Console.WriteLine("ID\t\tName\t\tDosageForm\t\tStrength\t\tManufacturing Date\t\tExpiry Date\t\tPrice\t\tMinStock\t\tStock");
            foreach (Product product in productList)
            {
                if (product is Medicine)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            Console.ReadKey();
        }
        public static CartItem AddToCartInput()
        {
            while (true)
            {
                Console.WriteLine("Enter product ID you want to buy");
                string id = Console.ReadLine();
                Product product = ProductValidation.ReturnProduct(id);

                if (product == null)
                {
                    Console.WriteLine("Product not found. Try again or press 'X' to exit.");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.X)
                        return null;
                }
                else
                {
                    Console.WriteLine("How many Quantity you want to enter");
                    int Quantity=int.Parse(Console.ReadLine());
                    if(ProductValidation.IsValidQuantity(Quantity)&&Quantity<product.GetStock())
                    {
                        CartItem cartItem = new CartItem(product.GetID(),product.GetName(), Quantity,product.GetPrice());
                        return cartItem;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

       }
        public static CartItem InputRemoveCart(List<CartItem>cart)
        {
            while (true)
            {
                Console.WriteLine("Enter product ID you want to remove from cart");
                string id = Console.ReadLine();
                CartItem product = ProductValidation.ReturnProductFromCart(id,cart);

                if (product == null)
                {
                    Console.WriteLine("Product not found. Try again or press 'X' to exit.");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.X)
                        return null;
                }
                else
                {
                    return product;
                }
            }

        }
        public static void  ViewCart(List<CartItem>cart)
        {
            Console.WriteLine("Name\tQuantity\tPrice");
            foreach (CartItem cartItem in cart)
            {
                Console.WriteLine($"{cartItem.GetName()}\t{cartItem.GetQuantity()}" +
                       $"\t\t{cartItem.GetPrice()}");
            }
        }
        public static void DisplayCustomer(string name,string address)
        {
            Console.WriteLine("Name:"+name+"\nAddress:"+address);

        }
        public static bool DisplayBill(float bill)
        {
            float payment = 0;
            Console.WriteLine("Your bill is:"+bill+"\nEnter amount");
            while (true)
            {
                try
                {
                    payment = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("invalid");
                }
            }
                if (payment == bill)
                {
                    Console.WriteLine("Transaction successful");
                return true;
                }
                else
                {
                    Console.WriteLine("Try again");
                return false;
                }
        }
        public static void DeleteAccount()
        {
            Console.WriteLine("You want to Delete Account!");
        }
    }
}
