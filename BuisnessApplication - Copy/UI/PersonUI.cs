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
    class PersonUI
    {
        static public int AdminMenu()
        {
            int choice = 0;
            Console.WriteLine("1.Add products");
            Console.WriteLine("2.View all products");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.Update Product");
            Console.WriteLine("5.Products to be ordered");
            Console.WriteLine("6.Remove Expire Medicines");
            Console.WriteLine("7.Add Users");
            Console.WriteLine("8.View transaction details");
            Console.WriteLine("9.LogOut");
            Console.WriteLine("Enter choice:");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
        }
        public static int MainMenu()
        {
            int choice = 0;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
        }
        public static int CustomerMenu()
        {
            int choice = 0;
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Add to cart");
            Console.WriteLine("3.Remove From cart");
            Console.WriteLine("4.View Equipments");
            Console.WriteLine("5.View Medicines");
            Console.WriteLine("6.Generate Invoice");
            Console.WriteLine("7.Log Out");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Enter your choice");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid choice");
            }
            return choice;
        }
        public static Person TakeInputCustomer()
        {
            string name, password;
            while (true)
            {
                Console.WriteLine("Enter Username");
                name = Console.ReadLine();
                if (!Validations.CheckName(name)&&name!=null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The name already exists!");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter Passsword");
                password = Console.ReadLine();
                if (Validations.CheckPassword(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid password!\n " +
                        "password should have length eight an uppercase,lowercase and special character)");
                }
            }
                Console.WriteLine("Enter address");
                string address = Console.ReadLine();
                Customer customer = new Customer(name, password, address);
                return customer;
        }
        public static Person TakeInputFromAdmin()
        {
            string role,name,password;
            while (true)
            {
                Console.WriteLine("Enter Username");
                name = Console.ReadLine();
                if(!Validations.CheckName(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The name already exists!");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter Passsword");
                password = Console.ReadLine();
                if(Validations.CheckPassword(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid password!\n " +
                        "password should have length eight an uppercase,lowercase and special character)");
                }
            }
            while(true)
            {
                Console.WriteLine("Enter role");
                string Role = Console.ReadLine();
                role = Role.ToLower();
                if(Validations.CheckRole(role))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid role");
                }
            }
            if (role == "admin")
            {
                        Admin admin = new Admin(name, password);
                        return admin;
            }
            else if (role == "customer")
            {
                Console.WriteLine("Enter address");
                string address = Console.ReadLine();
                Customer customer = new Customer(name, password, address);
                return customer;
            }
            return null;
        }
        public static void Succeed()
        {
            Console.WriteLine("Process done successfully!");
        }
        public static Person TakeInputSignIn()
        {
            Console.WriteLine("Enter UserName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Passsword");
            string password = Console.ReadLine();
            return Validations.CheckPersonInList(name, password);
        }
    }
}
