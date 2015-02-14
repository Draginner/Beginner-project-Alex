using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldAreYou10YLater
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Console.WriteLine("Write your age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0}", Age);
            Age = Age + 10;
            Console.WriteLine("You will be  {0} years old after 10 years",Age );
        }
    }
}
