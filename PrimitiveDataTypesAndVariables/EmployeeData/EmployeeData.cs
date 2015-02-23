using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {int x;
        string firstName = "Aleksandar";
            string lastName = "Tenchev";
            short age = 25;
            char gander = 'M' ;

            long personalIDNumber = 8306112507;
            int uniqueEmployeeNumber = 27560000;
            Console.WriteLine("Firstname of the worker:{0}",firstName);
            Console.WriteLine("Lastname of the worker:{0}",lastName);
            Console.WriteLine("Age of the worker:{0}",age);
            
            Console.WriteLine("Gander: {0} ",gander);
            Console.WriteLine("ID number of the worker: {0}",personalIDNumber);
            Console.WriteLine("Worker's number: {0}", uniqueEmployeeNumber);
            
        }
    }
}
