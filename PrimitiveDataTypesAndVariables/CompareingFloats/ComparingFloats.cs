using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            float firstValue = 0.568346f;
            float secondValue = 0.568346f;
            double eps;
            eps = Math.Abs(firstValue - secondValue);
            Console.WriteLine(eps < 0.000001);
        }
    }
}
