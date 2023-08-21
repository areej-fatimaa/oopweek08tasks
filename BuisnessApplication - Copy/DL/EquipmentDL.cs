using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class EquipmentDL
    {
        public static void StoreInFileEquipments()
        {
            string path = "D:\\oopWeek08pd\\BuisnessApplication - Copy\\Equipment.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Product product in ProductDL.productList)
            {
                if (product is Equipments)
                {
                    Equipments equipment = (Equipments)product;
                    file.WriteLine(product.GetID() + "," + product.GetName() + "," +
                    equipment.GetWarrenty() + "," +
                     product.GetPrice() + "," + product.GetminQuantity() + "," + product.GetStock());
                }
            }
            file.Flush();
            file.Close();
        }
        public static void ReadEquipmentfromFile()
        {
            string path = "D:\\oopWeek08pd\\BuisnessApplication\\Equipment.txt";

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
                    int Warrenty = int.Parse(records[2]);
                    int price = int.Parse(records[3]);
                    int minQuantity = int.Parse(records[4]);
                    int stock = int.Parse(records[5]);
                    Equipments equipment = new Equipments(ID, name, price, stock, minQuantity, Warrenty);
                   ProductDL.productList.Add(equipment   );
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
