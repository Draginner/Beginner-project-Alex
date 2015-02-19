using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesAndStrings
{
    class QuotesAndStrings
    {
        static void Main(string[] args)
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString =@"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
