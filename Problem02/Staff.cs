using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name,string address,string school,double pay):base(name,address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string GetSchool()
        {
            return school;
        }
        public double GetPay()
        {
            return pay;
        }
        public void SetSchool(string school)
        {
            this.school = school;
        }
        public void SetPay(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            return "Name: " + name + " ,Address: " + address + " ,School: " + school + " ,Pay: " + pay;
        }
    }
}
