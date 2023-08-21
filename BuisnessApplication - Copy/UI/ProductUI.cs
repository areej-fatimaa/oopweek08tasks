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
    class ProductUI
    {
        public static int AskCount()
        {
            int count;
            while (true)
            {
                Console.WriteLine("How many products you want to enter");
                try
                {
                    count = int.Parse(Console.ReadLine());
                    if (ProductValidation.IsValidQuantity(count))
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return count;
        }
        public static Product InputAddProducts()

        {
            string ID, name, dosageForm="", strength="",Type;
            int price, minQuantity, stock;
            DateTime expirationDate = DateTime.MinValue;
            DateTime manufacturingDate= DateTime.MinValue ;
            int warrantyPeriod=0;
            while (true)
                { 
                     Console.WriteLine("Enter product ID");
                      ID = Console.ReadLine();
                        if(ProductValidation.CheckProduct(ID)&&ID!="")
                        {
                            break;
                        }
                    else 
                    {
                        Console.WriteLine("Product already exsists");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter name of the product");
                     name = Console.ReadLine();
                     if(ProductValidation.Checknull(name))
                     {
                       break;
                     }
                else
                {
                    Console.WriteLine("This field is required");
                }
                }
                while (true)
                {
                      Console.WriteLine("Enter type of product");
                       string type = Console.ReadLine();
                     Type = type.ToLower();
                if(Type=="medicine"||Type=="equipment")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid type");
                }

                }
            if (Type == "medicine")
            {
                while (true)
                {
                    Console.WriteLine("Enter strenght of product");

                    strength = Console.ReadLine();
                    if (ProductValidation.Checknull(strength))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This field is required");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter dosage form(liquid or tablet)");
                    dosageForm = Console.ReadLine();
                    if (ProductValidation.Checknull(dosageForm) && dosageForm == "tablet" || dosageForm == "liquid")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This field is required");
                    }
                }
                bool isValidManufacturingDate = false;
                while (!isValidManufacturingDate)
                {
                    Console.Write("Manufacturing Date (YYYY-MM-DD): ");
                    isValidManufacturingDate = DateTime.TryParse(Console.ReadLine(), out manufacturingDate);
                    if (!isValidManufacturingDate)
                    {
                        Console.WriteLine("Invalid manufacturing date format. Please enter in the format (YYYY-MM-DD).");
                    }
                }
                bool isValidExpirationDate = false;
                while (!isValidExpirationDate)
                {
                    Console.Write("Expiration Date (YYYY-MM-DD): ");
                    isValidExpirationDate = DateTime.TryParse(Console.ReadLine(), out expirationDate);
                    if (!isValidExpirationDate)
                    {
                        Console.WriteLine("Invalid expiration date format. Please enter in the format (YYYY-MM-DD).");
                    }
                }
            }
            if(Type=="equipments")
            {
                bool isValidWarrantyPeriod = false;
                while (!isValidWarrantyPeriod)
                {
                    Console.Write("Warranty Period (in months): ");
                    isValidWarrantyPeriod = int.TryParse(Console.ReadLine(), out warrantyPeriod);
                    if (!isValidWarrantyPeriod)
                    {
                        Console.WriteLine("Invalid warranty period. Please enter a valid integer value.");
                    }
                }
            }

            while (true)
                {
                    Console.WriteLine("Enter price of product");
                    {
                        try
                        {
                            price = int.Parse(Console.ReadLine());
                            if(price>0&&price<1000000)
                            {
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid");
                        }
                    }
                }
                while(true)
                {
                    Console.WriteLine("Enter thresh hold value");
                    try
                    {
                        minQuantity = int.Parse(Console.ReadLine());
                        if(minQuantity>0)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter stock");
                    try
                    {
                        stock = int.Parse(Console.ReadLine());
                        if (stock > 0)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                if(Type=="medicine")
            {
                Medicine product = new Medicine(name,ID,strength,dosageForm,price,stock,minQuantity,manufacturingDate,expirationDate);
                return product;
            }
                if(Type=="equipment")
            {
                Equipments product = new Equipments(ID,name,price,stock,minQuantity,warrantyPeriod);
                    return product;
            }
            return null;
        }
        public static void ViewAllProducts(List<Product>productList)
        {
            foreach(Product product in productList)
            {
                if(product is Medicine)
                {
                    Console.WriteLine("ID\tName\t\tDosageForm\t\tStrength\t\tManufacturing Date\t\tExpiry Date\t\tPrice\t\tMinStock\tStock");
                   Console.WriteLine( product.ToString());
                }
                if(product is Equipments)
                {
                    Console.WriteLine("ID\t\tName\t\tWarrenty\t\tPrice\t\tMinStock\t\tStock");
                  Console.WriteLine(product.ToString());
                }
            }
            Console.ReadKey();
        }
        public static Product InputDelete()
            {
                while (true)
                {
                    Console.WriteLine("Enter product ID you want to delete");
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
                        return product;
                    }
                }
        }
        public static void UpdateProduct()
        {
            Console.WriteLine("Enter product ID you want to update");
            string id = Console.ReadLine();
            Product product = ProductValidation.ReturnProduct(id);
            if (product == null)
            {
                Console.WriteLine("Product not exists");
            }
            else
            {
                Console.WriteLine("ID\tName\tPrice\tMinQuantity\tStock");
                Console.WriteLine(product.GetID() + "\t" + product.GetName() +
                    "\t\t" + product.GetPrice() + "\t\t" + product.GetminQuantity() + "\t\t" + product.GetStock());

                Console.WriteLine("Enter information you want to update");
                        string information = Console.ReadLine();
                        string info = information.ToLower();
                        if(info=="name")
                        {
                            Updatename(product);

                        }
                        else if(info=="price")
                        {
                          UpdatePrice(product);
                        }
                Console.WriteLine("Product updated successfully!");
                Console.ReadKey();
            }
        }
        public static void Updatename(Product product)
        {
            while (true)
            {
                Console.WriteLine("Enter name of the product");
                string name = Console.ReadLine();
                if (ProductValidation.Checknull(name))
                {
                    product.SetName(name);
                    break;
                }
                else
                {
                    Console.WriteLine("This field is required");
                }
            }
        }
        public static void UpdatePrice(Product product)
        {
            while (true)
            {
                Console.WriteLine("Enter price of product");
                {
                    try
                    {
                        int price = int.Parse(Console.ReadLine());
                        if (price > 0 && price < 1000000)
                        {
                            product.SetPrice(price);
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }
        }
          public static void ProductsTobeOrdered(List<Product>productList)
          {
            if (productList.Count > 0)
            {
                Console.WriteLine("ID\tName\tPrice\tMinQuantity\tStock");
                foreach (Product product in productList)
                {
                    Console.WriteLine($"{product.GetID()}\t{product.GetName()}\t{product.GetminQuantity()}\t{product.GetStock()}");
                }
            }
            else
            {
                Console.WriteLine("Nothing to be ordered!");
            }
          }
        public static void RemoveExpireProductsConformation(List<Product>ExpireMedicines)
        {
            if (ExpireMedicines.Count > 0)
            {
                Console.WriteLine("ID\tName\tPrice\tMinQuantity\tStock");
                foreach (Product product in ExpireMedicines)
                {
                    Console.WriteLine($"{product.GetID()}\t{product.GetName()}\t{product.GetminQuantity()}\t{product.GetStock()}");
                }
            }
            else
            {
                Console.WriteLine("Nothing to be ordered!");
            }
               Console.WriteLine("Do you really wants to remove these products");
               Console.ReadKey();  
        }
    }
}
