using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = UI.StudentInput();
            DL.AddToList(stu1);
            Student stu2 = UI.StudentInput();
            DL.AddToList(stu2);
            Staff st1 = UI.StaffInput();
            DL.AddToList(st1);
            Staff st2 = UI.StaffInput();
            DL.AddToList(st2);
            List < Person >list = DL.ReturnList();
            UI.PrintInfo(list);
            Console.ReadKey();
        }
    }
}
