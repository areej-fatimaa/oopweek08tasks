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
    class Medicine:Product
    {
        private string Strength;
        private string DosageForm;
        private DateTime manufacture;
        private DateTime Expiry;
        public Medicine(string name, string id, string strength, string dosageform, int price, int stock, int minQuantity, DateTime manufacture
           , DateTime expiry) : base(id, name, price, minQuantity, stock)
        {
            SetStrength(strength);
            SetDosageForm(dosageform);
        }
        public void SetManufatureDate(DateTime date)
        {
           this.manufacture = date;
        }
        public DateTime GetManufactureDate()
        {
            return manufacture;
        }
        public DateTime GetExpiryDate()
        {
            return Expiry;
        }
        public bool SetStrength(string strength)
        {
            if (strength != null)
            {
                this.Strength = strength;
                return true;
            }
            return false;
        }
        public bool SetDosageForm(string DosageForm)
        {
            if (DosageForm != null)
            {
                this.DosageForm = DosageForm;
                return true;
            }
            return false;
        }
        public string GetStrength()
        {
            return Strength;
        }
        public string GetDosageForm()
        {
            return DosageForm;
        }
        public override string ToString()
        {
            return ID + "\t\t" + Name + "\t\t" + DosageForm + "\t\t" + Strength + "\t\t" + manufacture + "\t\t" + Expiry + "\t\t" + Price + "\t\t" + minQuantity + "\t\t" + Stock;
        }
    }
}
