using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.UI;
using BuisnessApplication.DL;

namespace BuisnessApplication.DL
{
    class Validations
    {
        public static bool CheckName(string name)
        {
            bool flag = false;
            flag = PersonDL.personList.Any(obj => obj.GetName() == name);
            if (flag)
            {
                flag = true;
            }
            return flag;
        }
        public static Person CheckPersonInList(string name,string password)
        {
            foreach(Person person in PersonDL.personList)
            {
                if(person.GetName()==name&&person.GetPassword()==password)
                {
                    return person;
                }
            }
            return null;
        }
        public static bool CheckPassword(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (password.Length > 8 && password.Length < 15 && hasUpperCase && hasLowerCase && hasDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckRole(string Role)
        {
            if (Role == "admin" || Role == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
