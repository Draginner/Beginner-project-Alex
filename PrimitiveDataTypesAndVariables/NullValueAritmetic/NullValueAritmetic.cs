using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValueAritmetic
{
    class NullValueAritmetic
    {
        static void Main(string[] args)
        {
            int? firstValue = null;
            double? secondValue = null;
            
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            firstValue = firstValue + 1;
            secondValue = secondValue + 2;
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
        }
    }
}
