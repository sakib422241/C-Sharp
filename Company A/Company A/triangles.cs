using System;
using System.Collections.Generic;
using System.Text;

namespace Company_A
{
    class triangles
    {
        public float Height;
        public float Base;
        public float Length;

        public void triangledetails()
        {
            Console.WriteLine("Enter  Height of Triangle ");
            Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Base  ");
            Base = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Length of Triangle ");
            Length = float.Parse(Console.ReadLine());




        }
       

    }
}
