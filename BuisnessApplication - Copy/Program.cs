using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminDL.ReadAdminfromFile();
            CustomerDL.ReadCustomerfromFile();
            MedicineDL.ReadMedicinefromFile();
            EquipmentDL.ReadEquipmentfromFile();

            int choice = 0;
            while (choice != 3)
            {
                Console.Clear();
                choice = PersonUI.MainMenu();
                if (choice == 1)
                {
                    Person type=PersonUI.TakeInputSignIn();
                    if (type is Admin)
                    {
                        int adminOption = 0;
                        while (adminOption != 9)
                        {
                            Console.Clear();
                            adminOption = PersonUI.AdminMenu();
                            if(adminOption==1)
                            {
                                int count = ProductUI.AskCount();
                                for(int i=0; i<count;i++)
                                {
                                   Product product =ProductUI.InputAddProducts();
                                    ProductDL.AddProduct(product);
                                    if(product is Medicine)
                                    {
                                        MedicineDL.StoreInFileMedicine();
                                    }
                                    else if(product is Equipments)
                                    {
                                        EquipmentDL.StoreInFileEquipments();
                                    }
                                }
                            }
                            else if(adminOption==2)
                            {
                                ProductUI.ViewAllProducts(ProductDL.productList);
                            }
                            else if(adminOption==3)
                            {
                                Product product = ProductUI.InputDelete();
                                ProductDL.DeleteProduct(product);
                                if (product is Medicine)
                                {
                                    MedicineDL.StoreInFileMedicine();
                                }
                                else if (product is Equipments)
                                {
                                    EquipmentDL.StoreInFileEquipments();
                                }
                                Console.WriteLine("Product deleted successfully!");
                            }
                            else if(adminOption==4)
                            {
                                ProductUI.UpdateProduct();
                                    MedicineDL.StoreInFileMedicine();
                                    EquipmentDL.StoreInFileEquipments();
                            }
                            else if(adminOption==5)
                            {
                                List<Product> ExpirationList = ProductDL.ExpireProducts();
                                ProductUI.RemoveExpireProductsConformation(ExpirationList);
                                ProductDL.RemoveExpireProducs();
                            }
                            else if(adminOption==6)
                            {
                                List<Product> List = ProductDL.ProductToBeOrdered();
                                ProductUI.ProductsTobeOrdered(List);
                            }
                            else if(adminOption==7)
                            {
                               Person person= PersonUI.TakeInputFromAdmin();
                                bool flag=PersonDL.SignUp(person);
                                if (flag)
                                {
                                    if (person is Admin)
                                    {
                                        AdminDL.StoreInFileAdmin(person);
                                    }
                                    else if(person is Customer)
                                    {
                                        CustomerDL.StoreInFileCustomer();
                                    }
                                }
                            }
                            else if(adminOption==8)
                            {
                                AdminDL.LoadTransactionsFromFile();
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (type is Customer)
                    {
                            int customerOption = 0;
                        while (customerOption != 8)
                        {
                            Console.Clear();
                            customerOption = PersonUI.CustomerMenu();
                            if(customerOption==1)
                            {
                                CustomerUI.ViewProducts(ProductDL.productList);
                            }
                            else if(customerOption==2)
                            {
                                CustomerUI.ViewProducts(ProductDL.productList);
                                int count= ProductUI.AskCount();
                                for(int i=0;i<count;i++)
                                {
                                   CartItem cartItem= CustomerUI.AddToCartInput();
                                    Customer.AddToCart(cartItem);
                                }
                            }
                            else if(customerOption==3)
                            {
                                CustomerUI.ViewCart(Customer.ReturnCart());
                               List<CartItem> cart =Customer.ReturnCart();
                                CartItem product = CustomerUI.InputRemoveCart(cart);
                                Customer.RemoveFromCart(product);
                            }
                            else if(customerOption==4)
                            {
                                CustomerUI.ViewEquipmentsOnly(ProductDL.productList);
                            }
                            else if (customerOption == 5)
                            {
                                CustomerUI.ViewMedicinesOnly(ProductDL.productList);
                            }
                            else if (customerOption == 6)
                            {
                                float bill = Customer.Bill();
                                Customer customer = (Customer)type;
                                CustomerUI.DisplayCustomer(type.GetName(),customer.GetAddress());
                                CustomerUI.ViewCart(Customer.ReturnCart());
                                bool flag=CustomerUI.DisplayBill(bill);
                                if (flag)
                                {
                                    ProductDL.MinimizeStock(Customer.ReturnCart());
                                        MedicineDL.StoreInFileMedicine();
                                        EquipmentDL.StoreInFileEquipments();
                                    AdminDL.SaveTransactionsToFile(type, Customer.ReturnCart());
                                    Customer.DestroyCart();
                                }
                            }
                            else if(customerOption==7)
                            {  
                                CustomerUI.DeleteAccount();
                                PersonDL.RemoveCustomer(type);
                                CustomerDL.StoreInFileCustomer();
                                break;
                            }
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You entered invalid information!");
                    }
                }
                else if (choice == 2)
                {
                    bool flag = false;
                        Person person = PersonUI.TakeInputCustomer();
                    flag=PersonDL.SignUp(person);
                    if(flag)
                    {
                        if(person is Customer)
                        {
                            CustomerDL.StoreInFileCustomer();
                        }
                        PersonUI.Succeed();
                    }
                      
                }
                Console.ReadKey();
            }
        }
    }
}
