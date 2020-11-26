using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student I = new Student();
            Traingle T = new Traingle();
            Account A = new Account();
            I.Name = "Sakib";
            I.Id = "19-41783-3";
            I.Department = "CSE";
            I.Cgpa = 4;
            
            T.X = 4;
            T.Y = 4;
            T.Z = 7;

            A.Accountname = " Student Account ";
            A.AccountID = "422242";
            A.Balance = 10000.0000;
            A.Deposite = 500.000;
            A.Withdraw = 100.00;
           
            I.showinfo();
            T.showInfo();
            T.Testtriangle();
            A.ShowDetails();
            Console.ReadLine();
        }

    }
}
