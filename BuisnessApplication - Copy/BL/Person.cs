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
    class Person
    {
        protected string Name;
        protected string Password;
        public Person(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetPassword()
        {
            return Password;
        }
        //public string GetRole()
        //{
        //    return role;
        //}
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetPassword(string password)
        {
            this.Password = password;
        }
        //public void SetRole(string role)
        //{
        //    this.role = role;
        //}
    }
}
