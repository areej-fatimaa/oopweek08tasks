using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Cylinder:Circle
    {
        private double Height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double radius):base (radius)
        {
        }
        public Cylinder (double radius ,double height):base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double radius, double height,string colour) : base(radius,colour)
        {
            this.Height = height;
        }
        public  double GetHeight()
        {
            return Height;
        }
        public void SetHeight(double height)
        {
            this.Height = height;
        }
        public double Vol()
        {
            return Height * base.radius * base.radius;
        }
    }
}
