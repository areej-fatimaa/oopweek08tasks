using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class DL
    {
        public static List<Person>list =new List<Person>();
        public static void AddToList(Person stu)
        {
            list.Add(stu);
        }
        public static List<Person> ReturnList()
        {
            return list;
        }
    }
}
