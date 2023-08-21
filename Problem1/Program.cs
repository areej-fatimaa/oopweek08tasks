using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(3.1333);
            Cylinder c3 = new Cylinder(3.5, 4.5);
            c1.SetHeight(4.5);
            double volume=c3.Vol();

        }
    }
}
