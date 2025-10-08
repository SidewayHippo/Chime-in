using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    class Program
    {
       public static void Main(string[] args)
        {
            //this is use to hold string or int,double

            string name = "John Wick", job = "Assassin", place = "New York", email = "unknown";
            double salary =200000.00, cost = 80000.00;
            int age = 48;

            //executing code by applying the string int and double 
            Console.WriteLine("Target Name; {0}\nRecent job: {1}\nRecent Location: {2}\nEmail of target: {3}\nAge: {4}\nReward :{5}\nParticipation Cost: {6}",name,job,place,email,age,salary,cost);
        }
    }
}
