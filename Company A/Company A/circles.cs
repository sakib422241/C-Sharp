using System;
using System.Collections.Generic;
using System.Text;

namespace Company_A
{
    class circles:rectangles
    {
        public double redius;
        public double pie = 3.14;
        public void circledetails() 
        {
            Console.WriteLine("Enter Redius of Circle");
            redius = float.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle : " + (.5 * Height * Base));
            Console.WriteLine("Perimeters of Triangle : " + (Height + Base + Length));
            Console.WriteLine("Area of Rectangle : " + (Length2 * Breadth));
            Console.WriteLine("Perimeters of Rectangle : " + (2 * (Length2 + Breadth)));
            Console.WriteLine("Area of Circle : " + (pie*(redius*redius)));
            Console.WriteLine("Perimeters of Circle : " + (2 *pie*redius));
        }
    }
}
