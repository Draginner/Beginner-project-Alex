using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Table
{
    class ASCIITable
    {
        static void Main(string[] args)
        {
            char c;
            for (int i = 0; i <= 255; i++)
            {
                c = (char)i;
                if (char.IsSymbol(c) || char.IsLetter(c) || char.IsNumber(c))
                {
                    Console.WriteLine("{0} -> {1}", i, (char)i);
                }
            }
        }
    }
}
