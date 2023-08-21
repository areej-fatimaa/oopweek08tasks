using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Dog:Mammal
    {
        public Dog(string name):base(name)
        { 
        }
        public override string ToString()
        {
            return "Cat:Mammal:Animal: " + name;
        }
        public override void Greets()
        {
            Console.WriteLine("Woof");
        }
    }
}
