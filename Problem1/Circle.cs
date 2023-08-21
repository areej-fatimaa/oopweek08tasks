using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Circle
    {
        protected double radius =1.0;
        protected string colour = "red";
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string colour)
        {

        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string GetColour()
        {
            return colour;
        }
        public void SetColour(string colour)
        {
            this.colour = colour;
        }
        public double GetArea()
        {
            return 3.14 * radius * radius;
        }
        public string toString()
        {
            string str = "Circle[radius=" + radius + ",colour=" + colour;
            return str;
        }
    }
}
