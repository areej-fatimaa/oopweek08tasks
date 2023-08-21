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
    class PersonDL
    {
        public static List<Person> personList = new List<Person>();
        public static bool SignUp(Person person)
        {
            personList.Add(person);
            return true;
        }
        public static bool SignUpAdmin(Person person)
        {
            personList.Add(person);
            return true;
        }
        public static Type SignIn(string name)
        {
            foreach(Person person in personList)
            {
                if(name==person.GetName())
                {
                   return person.GetType();
                }
            }
            
            return null;
        }
        public static void RemoveCustomer(Person person)
        {
            personList.Remove(person);
        }

    }
}
