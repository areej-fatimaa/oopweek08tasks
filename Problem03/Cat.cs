using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Cat:Mammal
    {
        public Cat(string name):base(name)
            {
            }
        public override string ToString()
        {
            return "Dog:Mammal:Animal: " + name;
        }
        public override void Greets()
        {
            Console.WriteLine("Meow");
        }
    }
}
