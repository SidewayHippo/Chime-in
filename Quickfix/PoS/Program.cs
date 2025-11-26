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
            Console.Clear();
            Console.WriteLine("===== RECEIPT =====");
            Console.WriteLine($"Organs: ${totalOrgans:N0}");
            Console.WriteLine($"Guns: ${totalGuns:N0}");
            Console.WriteLine($"Services: ${totalService:N0}");
            Console.WriteLine("-------------------");
            Console.WriteLine($"TOTAL: ${(totalOrgans + totalGuns + totalService):N0}");
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            Menu();
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
                Console.WriteLine("you will get a random pistol");
                c = c + 200;
                totalGuns += c;
                Guns();
            }
            else if (g == 2)
            {

                Console.WriteLine("Illegal to own NO");
                c = c + 400;
                totalGuns += c;
                Guns();
            }
            else if (g == 3)
            {
                Console.WriteLine("Sir/Ma'am you are an idiot");
                c = c + 800;
                totalGuns += c;
                Guns();
            }
            else if (g == 4)
            {
                Console.WriteLine("are you mad? we dont sell that");
                c = c + 1000;
                totalGuns += c;
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
                Organs();
            }
            else if (o == 2)
            {

                Console.WriteLine("Yeah no we don't have that");
                q = q + 20000;
                totalOrgans += q;
                Organs();
            }
            else if (o == 3)
            {
                Console.WriteLine("Mate no we don't sell that");
                q = q + 15000;
                totalOrgans += q;
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
                Organs();
            }
            else if (d == 2)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Guns();
            }
            else if (d == 3)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Service();
            }
            else if (d == 4)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.BufferWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Total();
            }
        }

        static void Main(string[] args)
        {
            
            Menu();


        }
    }
}
