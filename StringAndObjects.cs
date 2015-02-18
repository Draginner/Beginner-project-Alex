using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        { string firstString = "Hello";
        string secondString = "World";
        Console.WriteLine(firstString + " " + secondString);
        object thirdThing = firstString + " " + secondString;
        Console.WriteLine(thirdThing);
        string thirdString = (string)thirdThing;
        Console.WriteLine(thirdString);
        }
    }
}
