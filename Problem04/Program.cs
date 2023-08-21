using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shap = new List<Shape>();
            Console.WriteLine("Enter width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side");
            int side = int.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(width, height);
            Circle circle = new Circle(radius);
            Square sq = new Square(side);
            shap.Add(circle);
            shap.Add(rec);
            shap.Add(sq);
            foreach(Shape s in shap)
            {
                Console.WriteLine("This is "+s.GetShape()+" and its area is "+s.Area());
            }
            Console.ReadKey();
        }
    }
}
