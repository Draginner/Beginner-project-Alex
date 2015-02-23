using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Write a number to check if its odd or even.");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} = {1} ",number , 0 == number % 2 );
        }
    }
}
