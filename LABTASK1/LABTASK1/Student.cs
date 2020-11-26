using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK1
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;
        public string Name   
        {
            get { return name; }
            set { name = value; }
        }
        public string Id   
        {
            get { return id; }
            set { id = value; }
        }
        public string Department   
        {
            get { return department; }
            set { department = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public void showinfo() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA: " + cgpa);

        }

    }
}
