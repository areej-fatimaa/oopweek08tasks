using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
        public virtual string  GetShape()
        {
            return "Undefined";
        }

    }
}
