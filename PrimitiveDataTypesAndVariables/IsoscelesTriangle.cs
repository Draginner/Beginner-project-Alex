using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            string copyRight = "\u00A9";
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Console.WriteLine("   {0}",copyRight);
            Console.WriteLine("  " + copyRight + " " + copyRight);
            Console.WriteLine(" " + copyRight+ "   "  + copyRight);
            Console.WriteLine(copyRight+" " +copyRight+" "+copyRight+" "+copyRight);
        }
    }
}
