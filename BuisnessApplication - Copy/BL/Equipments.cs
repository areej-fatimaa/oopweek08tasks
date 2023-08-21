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
    class Equipments : Product
    {
        private int warrenty;
        public Equipments(string id, string name, int price, int stock, int minQuantity, int warrenty) : base(id, name, price, minQuantity, stock)
        {
            this.warrenty = warrenty;
        }
        public void SetWarrenty(int warrenty)
        {
            this.warrenty = warrenty;
        }
        public int GetWarrenty()
        {
            return warrenty;
        }
        public override string ToString()
            {
            return ID + "\t\t" + Name + "\t\t" + warrenty + "\t\t" + Price + "\t\t" + minQuantity + "\t\t" + Stock;
            }
    }
}
