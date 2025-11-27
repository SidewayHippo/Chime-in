using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace papercut
{
    class Program
    {
        static double totalService = 0;
        static double totalGuns = 0;
        static double totalOrgans = 0;
        static double totalAll = 0;

        public static void ComputeD()
        {
            double v;
            Console.WriteLine("===== RECEIPT =====");
            Console.WriteLine($"Organs: ${totalOrgans:N0}");
            Console.WriteLine($"Guns: ${totalGuns:N0}");
            Console.WriteLine($"Services: ${totalService:N0}");
            Console.WriteLine("Discounted? Yes");
            Console.WriteLine("-------------------");
            Console.WriteLine($"TOTAL: ${totalAll:N0}");
            Console.Write("Please enter how much money here: ");
            v = Convert.ToDouble(Console.ReadLine());

            if (totalAll > v)
            {
                Console.WriteLine("Please enter higher or exact money, press any key to try again");
                Console.ReadKey();
                Console.Clear();
                ComputeD();
            }
            else if (totalAll == v)
            {
                Console.WriteLine("Thank you for your purchase, press any key to exit");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else if (totalAll < v)
            {
                Console.WriteLine("we dont do change so thanks for the extra, press any key to exit");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
        }
            public static void ComputeN()
            {
            double b,z;
            Console.WriteLine("===== RECEIPT =====");
            Console.WriteLine($"Organs: ${totalOrgans:N0}");
            Console.WriteLine($"Guns: ${totalGuns:N0}");
            Console.WriteLine($"Services: ${totalService:N0}");
            Console.WriteLine("Discounted? No");
            Console.WriteLine("-------------------");
            Console.WriteLine($"TOTAL: ${totalOrgans + totalGuns + totalService:N0}");
            Console.Write("Please enter how much money here: ");
            z = totalOrgans + totalGuns + totalService;
            b = Convert.ToDouble(Console.ReadLine());

            if (z > b)
            {
                Console.WriteLine("Please enter higher or exact money, press any key to try again");
                Console.ReadKey();
                Console.Clear();
                ComputeD();
            }
            else if (z == b)
            {
                Console.WriteLine("Thank you for your purchase, press any key to exit");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else if (z < b)
            {
                Console.WriteLine("we dont do change so thanks for the extra, press any key to exit");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
        }
        public static void Payment()
        {
            double d, k;
            string t;
            Console.Write("Do you have a voucher? Yes or no\n:");
            t = Console.ReadLine();

            if (t == "Yes")
            {
                string c;
                Console.Write("Input your code: ");
                c = Console.ReadLine();
                Console.ReadKey();
                Console.Clear();
                if (c == "CHESTPAIN" )
                {
                    d = totalGuns + totalOrgans + totalService * 0.300;
                    totalAll = d + totalAll;
                    Console.WriteLine("Proceeding to final step, press any key");
                    Console.ReadKey();
                    Console.Clear();
                    ComputeD();
                }
            }
            else if (t == "yes")
            {
                string c;
                Console.Write("Input your code: ");
                c = Console.ReadLine();
                Console.ReadKey();
                Console.Clear();
                if (c == "CHESTPAIN")
                {
                    d = totalGuns + totalOrgans + totalService * 0.300;
                    totalAll = d + totalAll;
                    Console.WriteLine("Proceeding to final step, press any key");
                    Console.ReadKey();
                    Console.Clear();
                    ComputeD();
                }

            }
            else if (t == "YES")
            {
                string c;
                Console.Write("Input your code: ");
                c = Console.ReadLine();
                Console.ReadKey();
                Console.Clear();
                if (c == "CHESTPAIN")
                {
                    d = totalGuns + totalOrgans + totalService * 0.300;
                    totalAll = d + totalAll;
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Proceeding to final step, press any key");
                    ComputeD();
                }
            }
            else if (t == "No")
            {
               Console.WriteLine("Proceeding to final step, press any key");
                    Console.ReadKey();
                    Console.Clear();
                ComputeN();
            }
            else if (t == "no")
            {
                Console.WriteLine("Redirecting you, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                ComputeN();
            }
            else if (t == "NO")
            {
                Console.WriteLine("Redirecting you, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                ComputeN();
            }
            else
                Console.WriteLine("Invalid response, please input yes or no, press any key first to retry");
                Console.ReadKey();
                Console.Clear();
            Payment();
        }
        public static void Total()
        {
            string d;
            Console.Write("would you like to pay now? type Yes or no\n:");
            d = Console.ReadLine();

            if (d == "yes")
            {
                Console.WriteLine("Redirecting you");
                Console.ReadKey();
                Console.Clear();
                Payment();
            }
            else if (d == "Yes")
            {
                Console.WriteLine("Redirecting you");
                Console.ReadKey();
                Console.Clear();
                Payment();
            }
            else if (d == "YES")
            {
                Console.WriteLine("Redirecting you");
                Console.ReadKey();
                Console.Clear();
                Payment();
            }
            else if (d == "no")
            {
                Console.WriteLine("putting you back to menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else if (d == "No")
            {
                Console.WriteLine("putting you back to menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else if (d == "NO")
            {
                Console.WriteLine("putting you back to menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
                Console.WriteLine("that is not part of the option");
                Console.ReadKey();
                Console.Clear();
                Total();
        }
        public static void Guns()
        {
            int g, c;
            Console.WriteLine("Which gun do you desire?");
            Console.WriteLine("\n1.Pistol");
            Console.WriteLine("2. Assault Riffle");
            Console.WriteLine("3. Designated Marksman riffle");
            Console.WriteLine("4. Light Machine Gun");
            Console.WriteLine("5. Return");
            Console.Write("Enter Here: ");
            g = Convert.ToInt32(Console.ReadLine());
            c = 0;

            if (g == 1)
            {
                Console.WriteLine("you will get a random pistol, $200");
                c = c + 200;
                totalGuns += c;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Guns();
            }
            else if (g == 2)
            {

                Console.WriteLine("A smart choice, $400");
                c = c + 400;
                totalGuns += c;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Guns();
            }
            else if (g == 3)
            {
                Console.WriteLine("Enjoy the killing spree, $800");
                c = c + 800;
                totalGuns += c;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Guns();
            }
            else if (g == 4)
            {
                Console.WriteLine("Happy hunting, $ 1000");
                c = c + 1000;
                totalGuns += c;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Guns();
            }
            else if (g == 5)
                Console.Clear();
                Menu();
        }
        public static void Organs()
        {
            int q,o;
            q = 0;
            Console.WriteLine("Which part do you desire?");
            Console.WriteLine("\n1.Heart");
            Console.WriteLine("2.Liver");
            Console.WriteLine("3.Kidney");
            Console.WriteLine("4.Retrun");
            Console.Write("Enter Here: ");
            o = Convert.ToInt32(Console.ReadLine());

            if (o == 1)
            {
                Console.WriteLine("To be delivered");
                q = q + 30000;
                totalOrgans += q;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Organs();
            }
            else if (o == 2)
            {

                Console.WriteLine("Great Choices");
                q = q + 20000;
                totalOrgans += q;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Organs();
            }
            else if (o == 3)
            {
                Console.WriteLine("Someone need a spare");               
                q = q + 15000;
                totalOrgans += q;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Organs();
            }
            else if (o == 4)
            {
                Console.Clear();
                Menu();
            }
        }
        public static void Service()
        { string s;
            Console.Write("Please enter the name of the target or enter cancel to go back to menu\n");
            s = Console.ReadLine();
            if (s == "Cancel")
            {
                Console.WriteLine("Redirecting you, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else if (s == "cancel")
            {
                Console.WriteLine("Redirecting you, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else if (s == "CANCEL")
            {
                Console.WriteLine("Redirecting you, press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
                Console.WriteLine("We have recieved enough information Target will be taken down in 7 days, press any key to continue");
            totalService = 40000;
            Console.ReadKey();
            Console.Clear();
            Service();
        }
        public static void Menu()
        {
            int d;
            Console.WriteLine("Welcome! to the Black Market");
            Console.WriteLine("\nPlease choose what you need");
            Console.WriteLine("1.Organs");
            Console.WriteLine("2.Guns");
            Console.WriteLine("3.assasination service");
            Console.WriteLine("4.Reciept");
            Console.Write("Enter your choice: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (d == 1)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Clear();
                Organs();
            }
            else if (d == 2)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Clear();
                Guns();
            }
            else if (d == 3)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Clear();
                Service();
            }
            else if (d == 4)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Clear();
                Total();
            }
        }

        static void Main(string[] args)
        {
            
            Menu();


        }
    }
}
