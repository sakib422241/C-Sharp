using System;
using System.Collections.Generic;
using System.Text;

namespace Company_A
{
    class rectangles :triangles
    {
        public float Breadth;
        public float Length2;
        public void rectangledetails()
        {
            Console.WriteLine("Enter  Length of Rectangle ");
            Length2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Breadth of Rectangle ");
            Breadth = float.Parse(Console.ReadLine());

        }
    }
}
