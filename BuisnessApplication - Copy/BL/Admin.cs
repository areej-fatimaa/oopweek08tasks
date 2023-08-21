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
    class Admin:Person
    {
        public Admin(string name, string password) : base(name, password)
        {
        }
    }
}
