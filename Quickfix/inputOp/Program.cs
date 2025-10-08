using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surgery
{
    class Program
    {
        static void Main(string[] args)
        {
            //input operation

            // having 2 double causes error so using using decimal and converting to float value removes error
            decimal prize, extra;
            string name, status, crime, whereabouts;

            //using console.write provides user inputs
            //using console.readline holds user inputs

            Console.Write("Enter the target's name: ");
            name = Console.ReadLine();

            Console.Write("Enter target's Status: ");
            status = Console.ReadLine();

            Console.Write("Enter Crime: ");
            crime = Console.ReadLine();

            Console.Write("Enter where last seen: ");
            whereabouts = Console.ReadLine();

            Console.Write("Phone tracked location: ");
            string phone = Console.ReadLine();

            Console.Write("Enter the money reward: ");
            prize = decimal.Parse(Console.ReadLine());

            Console.Write("Enter extra Money if head is Bring in: ");
            extra = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Transaction Successful!\n we are now hunting him down");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Crime committed: " + crime);
            Console.WriteLine("Last Location seen: " + whereabouts);

            //to make sure the number all appear instead of {0:D} we can convert it to {0:F}
            Console.WriteLine("Prize for executing target: {0:F2}", prize);

            ////do note some numbers can't be used as string however you can use "$" to make it interpolated string
            Console.WriteLine($"Tracking current location: {phone}");
            Console.WriteLine($"Extra money reward if head is brought: {extra}");
        }
    }
}
