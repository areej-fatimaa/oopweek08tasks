using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name,string address)
        {
            this.name=name;
            this.address = address;
        }
        public String GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return "Name:" + name + ",Address:" + address;
        }
    }
}
