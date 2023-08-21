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
    class MedicineDL
    {
        public static void StoreInFileMedicine()
        {
            string path = "D:\\oopWeek08pd\\BuisnessApplication - Copy\\Medicine.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Product product in ProductDL.productList)
            {
                if (product is Medicine)
                {
                    Medicine medicine = (Medicine)product;
                    file.WriteLine(product.GetID() + "," + product.GetName() + "," + medicine.GetStrength() +
                    "," + medicine.GetDosageForm() + "," + medicine.GetManufactureDate() + "," + medicine.GetExpiryDate() + "," +
                     product.GetPrice() + "," + product.GetminQuantity() + "," + product.GetStock());
                }
            }
            file.Flush();
            file.Close();
        }
         public static void ReadMedicinefromFile()
        {
            string path = "D:\\oopWeek08pd\\BuisnessApplication - Copy\\Medicine.txt";

            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] records = record.Split(',');
                    string ID = records[0];
                    string name = records[1];
                    string strength = records[2];
                    string dosageForm = records[3];
                    DateTime manufactureDate = DateTime.Parse(records[4]);
                    DateTime expirationDate = DateTime.Parse(records[5]);
                    int price = int.Parse(records[6]);
                    int minQuantity = int.Parse(records[7]);
                    int stock = int.Parse(records[8]);
                    Medicine medicine = new Medicine(name,ID,strength,dosageForm,price,stock,minQuantity,manufactureDate,expirationDate);
                   ProductDL.productList.Add(medicine);
                    x++;
                    if (x >ProductDL.productList.Count)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
        }
    }
}
