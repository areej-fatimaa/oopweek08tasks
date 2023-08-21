using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Circle:Shape
    {
        private int radius;
        public Circle (int radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
