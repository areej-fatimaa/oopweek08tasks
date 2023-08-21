using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Square:Shape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side*side;
        }
        public override string GetShape()
        {
            return "Square";
        }
    }
}
