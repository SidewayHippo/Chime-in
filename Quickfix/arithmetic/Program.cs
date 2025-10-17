using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simple arithmetic operation 
            //we will show multiple lines for each arithmetic operation
            int a = 20, b = 4;

            //additional number explained later
            int c = 8;
            //now to add operators 
            int sum = a + b;
            int dif = a - b;
            int pro = a * b;
            int quo = a / b;
            int rem = a % b;
            int inc = ++a;
            int dec = --b;

            //you can also compute 3 numbers 
            int tro = a + b + c;
            int tor = a - b - c;
            int por = a * b * c;

            Console.WriteLine("sum: " + sum);
            Console.WriteLine("difference: " + dif);
            Console.WriteLine("product: " + pro);
            Console.WriteLine("quotient: " + quo);
            Console.WriteLine("remainder: " + rem);
            Console.WriteLine("increment: " + inc);
            Console.WriteLine("decrement: " + dec);
            Console.WriteLine("other computation: \n" + tro);
            Console.WriteLine(tor);
            Console.WriteLine(por);
            //dividing 3 numbers would be difficult especially for int, double is highly reccomended
        }
    }
}
