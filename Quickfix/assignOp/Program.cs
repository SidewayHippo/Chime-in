using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itsgood
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we will do assignment operators(idk if im making sense, since i have 40 degree fever)
            int a = 5;
             a += 3;
            int b = 10;
            //+= 3 will compute to a (basically it's 5+3) you could use other operator such as -,*,/ and others

            b += a;

            Console.WriteLine($"answer: {a}");
            //notice there's a $ and that means interpolated string however for this scenario you can compute despite being an interpolated string
            Console.WriteLine($"another answer: {b}");
        }
    }
}
