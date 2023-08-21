using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Cat c1 = new Cat("billi1");
            list.Add(c1);
            Cat c2 = new Cat("billi2");
            list.Add(c2);
            Dog d1 = new Dog("dog1");
            list.Add(d1);
            Dog d2 = new Dog("dog2");
            list.Add(d2);
            foreach(Animal ani in list)
            {
                Console.WriteLine(ani.toString());
                ani.Greets();
            }
            Console.ReadKey();
        }
    }
}
