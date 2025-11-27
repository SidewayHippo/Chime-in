using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace papercut
{
    class Program
    {
        static int totalService = 0;
        static int totalGuns = 0;
        static int totalOrgans = 0;
        public static void Total()
        {
            int m, n;
            Console.Clear();
            Console.WriteLine("===== RECEIPT =====");
            Console.WriteLine($"Organs: ${totalOrgans:N0}");
            Console.WriteLine($"Guns: ${totalGuns:N0}");
            Console.WriteLine($"Services: ${totalService:N0}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"TOTAL: ${(totalOrgans + totalGuns + totalService):N0}");
            n = totalOrgans + totalGuns + totalService;
            Console.Write("\nPlease Input your Payment amount: ");
            m = Convert.ToInt32(Console.ReadLine());

            if (n > m)
            {
                Console.WriteLine("you don't have enough money, please re enter the exact amount or higher");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else if(n < m)
            {
                Console.WriteLine("we don't do changes so thanks for the purchase and the extra tip");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("thank you for your purchase");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(0);
            }
            
        }
        public static void Service()
        {
            string n;
            int s;
            Console.Write("Enter name: ");
            Console.WriteLine("\nor type x to return");
            n = Console.ReadLine();
            s = 0;
            if (n == "x")
            {
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("thank you, that will cost 400,000");
                s = s + 40000;
                totalService += s;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Service();
            }
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
                Console.WriteLine("sorry we don't sell that");
                q = q + 30000;
                totalOrgans += q;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Organs();
            }
            else if (o == 2)
            {

                Console.WriteLine("Yeah no we don't have that");
                q = q + 20000;
                totalOrgans += q;
                Console.Write("press any key to continue....");
                Console.ReadKey();
                Console.Clear();
                Organs();
            }
            else if (o == 3)
            {
                Console.WriteLine("Mate no we don't sell that");               
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
