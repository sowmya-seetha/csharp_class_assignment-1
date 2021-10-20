using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Q5
    {
        void area(float x)
        {
            Console.WriteLine("the area of the square is " + x*x + " sq units");
        }
        void area(float x, float y)
        {
            Console.WriteLine("the area of the rectangle is " + x * y + " sq units");
        }
        void area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle is " + z + " sq units");
        }
        void area(double x,double y)
        {
            double z = 0.5 * x * y;
            Console.WriteLine("the area of the triangle is " + z + " sq units");
        }
        static void Main()
        {
            Q5 ob = new Q5();
            ob.area(5);
            ob.area(11, 12);
            ob.area(2.5);
            ob.area(1.5, 2.5);

        }
    }
}
