using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class UI
    {
        public static Student StudentInput()
        {
            int year = 0;
            double fee = 0;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter program:");
            string program = Console.ReadLine();
            Console.WriteLine("Enter year");
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter numbers");
            }
            Console.WriteLine("Enter fee:");
            try
            {
                fee = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter valid information");
            }
            Student stu = new Student(name, address, program, year, fee);
            return stu;
        }
        public static Staff StaffInput()
        {
            double pay = 0;
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter school:");
            string school = Console.ReadLine();
            Console.WriteLine("Enter pay:");
            try
            {
                pay = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter valid information");
            }
            Staff st = new Staff(name, address,school,pay);
            return st;

        }
        public static void PrintInfo(List<Person>list)
        {
            foreach(Person p in list)
            {
                Console.WriteLine(p.toString()); 
            }
        }
    }
}
