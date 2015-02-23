using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main(string[] args)
        {
            int firstValue = 5;
            int secondValue = 10;
            int swapValue;
            Console.WriteLine(firstValue+ " "+ secondValue);
            swapValue= firstValue;
            firstValue = secondValue;
            secondValue = swapValue;
            Console.WriteLine(firstValue+ " " + secondValue);


        }
    }
}
