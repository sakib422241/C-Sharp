using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK1
{
    class Traingle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public void showInfo() 
        {
            Console.WriteLine(" X : " + x);
            Console.WriteLine(" Y : " + y);
            Console.WriteLine(" Z : " + z);

        }
        public void Testtriangle()
        {
            if (x == y && y == z && z == x)
            {
                Console.WriteLine("Equilateral");
            }
            else if (x == y || z == y)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
            
        }
    }
}
