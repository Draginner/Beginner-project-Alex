using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 254;
            string transformToHexa = "FE";
            Console.WriteLine("We transform the number {0} to hexadecimal and it is {1}",value,transformToHexa);
        }
    }
}
