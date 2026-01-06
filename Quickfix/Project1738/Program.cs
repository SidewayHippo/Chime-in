using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Setback
{
    class Program
    {
        static double Correct = 0;
        static double Wrong = 0;
        
        static void Main(string[] args)
        {
            MainMenu();
                
        }

        static void MainMenu()
        {
            Correct = 0;
            Wrong = 0;
            Console.Clear();
            Console.WriteLine("The Test of knowledge");
            Console.WriteLine("\n\n1.Play");
            Console.WriteLine("Press any to Exit");
            Console.Write($"");
            string n = Console.ReadLine();

            if (n == "1" || n == "play" || n == "Play")
            {
                Category();
            }
            else if (n == "2" || n == "Tutorial" || n == "tutorial"){
                HTP();
            }
            else
                Console.WriteLine("see you next time");
        }
        static void Category()
        {
            Console.Clear();
            Console.WriteLine("Please choose a category\n\n1.Places\n2.People\n3.Animals\nor any key to exit");
            Console.Write($"");
            string c = Console.ReadLine();

            if (c == "1" || c == "Places" || c == "places")
            {
                PlaceDifficulty();
            }
            else if (c == "2" || c == "People" || c == "people")
            {
                HumanDifficulty();
            }
            else if (c == "3" || c == "Animals" || c == "animals")
            {
                AnimalDifficulty();
            }
            else
                Console.WriteLine("see you next time!");
        }
        static void HTP()
        {
            Console.WriteLine("Tutorial\n\nTo answer properly you must input the correct spelling of the answer, once input press \"Enter\" key to lock in your answer");
            Console.WriteLine("\nGood Luck Have Fun and Learn more amazing things about everything we prepared");
            Console.WriteLine("Press \"X\" key to go to Main Menu or any key to exit");
            Console.Write("");
            string h = Console.ReadLine();

            if (h == "X" || h == "x")
            {
                MainMenu();
            }
            else
                Console.WriteLine("Goodbye!");
        }


//---------------------------------------------------------------------------------------------------------------------------------------------

        static void AnimalDifficulty()
        {
            
            Console.Clear();
            Console.WriteLine("This will talk about anything related to animals");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Choose your Difficulty");
            Console.WriteLine("1.Easy\n2.Normal\n3.Hard\nPress other keys to exit");
            Console.Write($"");
            string a = Console.ReadLine();

            if (a == "1" || a == "Easy" || a == "easy")
            {
                AEasy();
            }
            else if (a == "2" || a == "Normal" || a == "normal")
            {
                ANormal();
            }
            else if (a == "3" || a == "hard" || a == "Hard")
            {
                AHard();
            }
            else
                Console.WriteLine("see you next time!");
        }
        static void HumanDifficulty()
        {
            Console.Clear();
            Console.WriteLine("This will talk about anything related to Humans(Biology,celebreties, etc.)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Choose your Difficulty");
            Console.WriteLine("1.Easy\n2.Normal\n3.Hard\nPress other keys to exit");
            Console.Write($"");
            string h = Console.ReadLine();

            if (h == "1" || h == "Easy" || h == "easy")
            {
                HEasy();
            }
            else if (h == "2" || h == "Normal" || h == "normal")
            {
                HNormal();
            }
            else if (h == "3" || h == "Hard" || h == "hard")
            {
                HHard();
            }
            else
                Console.WriteLine("see you next time!");
        }
             
        static void PlaceDifficulty()
        {
            Console.Clear();
            Console.WriteLine("This will talk about anything related to places(Minerals found, locations, etc.)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Choose your Difficulty");
            Console.WriteLine("1.Easy\n2.Normal\n3.Hard\nPress other keys to exit");
            Console.Write($"");
            string d = Console.ReadLine();

            if (d == "1" || d == "Easy" || d == "easy")
            {
                PEasy();
            }
            else if (d == "2" || d == "Normal" || d == "normal")
            {
               PNormal();
            }
            else if (d == "3" || d == "Hard" || d == "hard")
            {
                PHard();
            }
            else
                Console.WriteLine("see you next time!");
        }






//Questions------------------------------------------------------------------------------------------------------------------------------------
        static void PEasy()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("What is the coldest city in the world?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "yakutsk" || p1 == "Yakutsk")
            {
               
                Console.Write("\n\nCorrect!");
                Console.WriteLine("\npress any key to proceed to continue...");
                Console.ReadKey();
                b = b + 1; 
                
            }
            else
            {
       
                Console.Write("\n\nWrong! the correct answer is \"Yakutsk\"");
                Console.WriteLine("\npress any key to continue...");
                Console.ReadKey();
                c = c + 1;
                
            }

            //2
            Console.Clear();
            Console.WriteLine("What is the official currency of United kingdom?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "British Pound" || p2 == "british pound" || p2 == "Pound Sterling" || p2 =="pound sterling")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
                
            }
            else
            {
                Console.WriteLine("\n\nWrong! The correct answer is \"British Pounds or pound sterling\"");
                Console.Write("press any to continue...");
                Console.ReadKey();
                c = c + 1;
                
            }

            //3
            Console.Clear();
            Console.WriteLine("What country lies above Mexico?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "USA" || p3 == "usa" || p3 == "United States of America" || p3 == "united states of america")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("\npress any key to continue...");
                Console.ReadKey();
                b = b + 1;

            }
            else
            {
                Console.WriteLine("\n\nWrong!The correct answer is \"USA or United states of america\"");
                Console.Write("press any to continue...");
                Console.ReadKey();
                c = c + 1;
                
            }

            //4
            Console.Clear();
            Console.WriteLine("What is the name of the tallest mountain in the world?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Mt. Everest" || p4 == "mt. everest" || p4 == "Everest" || p4 =="everest")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any key to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"the Mount Everest\"");
                Console.Write("press any to continue...");
                Console.ReadKey();
                c = c + 1;
                
            }

            //5
            Console.Clear();
            Console.WriteLine("What is the capital city of England?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "London" || p5 == "london")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any key to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is the \"London\"");
                Console.Write("press any to continue...");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("Which country has the largest population in the world?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "China" || p6 == "china")
            {
                Console.WriteLine("\n\nCorrect!"); 
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"China\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
               
            }


            //7
            Console.Clear();
            Console.WriteLine("What is the name of the longest river in Africa?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "The nile river" || p7 == "the nile river" || p7 == "Nile river" || p7 == "nile river")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"The nile river\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("What American city is the Golden Gate Bridge located in?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "San francisco" || p8 == "san francisco" || p8 == "San Francisco")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"San francisco\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("What is the capital of Mexico?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Mexico city" || p9 == "mexico city" || p9 == "Mexico City")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mexico city\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("What U.S. state is home to no documented venomous snakes?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "Alaska" || p10 == "alaska")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Alaska\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Where is eifel tower located?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Paris" || p11 == "paris")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Paris\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("What is the capital of Canada?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Ottawa" || p12 == "ottawa")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ottawa\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("What is the capital of thailand?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Bangkok" || p13 == "bangkok")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Bangkok\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What is the name of the smallest country in the world?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Vatican" || p14 == "vatican")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Vatican\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What is capital of Spain?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "Madrid" || p15 == "madrid")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Madrid\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }

        static void PNormal()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("What is the capital city of Brazil?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "brasilia" || p1 == "Brasilia")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Brasilia\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("Which mountain range is the longest in the world?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "The Andes" || p2 == "the andes" || p2 == "The andes")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"The Andes\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What is the largest island in the world?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Greenland" || p3 == "greenland")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Greenland\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Before becoming President, Barack Obama served as a U.S. Senator from which state?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Illinois" || p4 == "illinois")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Illinois\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("Which Ocean did the titanic sink?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "North atlantic ocean" || p5 == "north atlantic ocean" || p5 == "atlantic ocean" || p5 == "Atlantic ocean")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"North atlantic ocean\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("What is the capital city of Argentina");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Buenos aires" || p6 == "buenos aires")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Buenos aires\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("What is the currency of Japan?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Japanese yen" || p7 == "japanese yen" || p7 == "Japanese Yen")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Japanese Yen\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("Where was Napoleon born?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Corsica" || p8 == "corsica")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Corsica\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("Where was jose rizal got deported to?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Dapitan" || p9 == "dapitan")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Dapitan\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("Where was the first Olympics held?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "Greece" || p10 == "greece")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Greece\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Which planet rotates sideward?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Uranus" || p11 == "uranus")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Uranus\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("What is the capital of South Korea?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Seoul" || p12 == "seoul")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Seoul\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("Which country has unicorn as their national animal?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Scotland" || p13 == "scotland")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Scotland\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What is the northernmost capital city in the world?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Reykjavik" || p14 == "reykjavik")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Reyjavik\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("Which country (of today) Nikola Tesla birtplace?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "Croatia" || p15 == "croatia")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Croatia\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }

        static void PHard()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("What is the capital city of Mongolia?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Ulaanbaatar" || p1 == "ulaanbaatar")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ulaanbaatar\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("Benjamin Franklin was a key figure in the drafting of the United States Constitution. Which state did he represent during the Constitutional Convention in 1787?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Pennsylvania" || p2 == "pennsylvania")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Pennsylvania\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What is the capital of bhutan?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Thimpu" || p3 == "thimpu")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Thimpu\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Which planet is known as the Red Planet?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Mars" || p4 == "mars")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mars\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("What is the national gemstone of Australia, also known as fire of the dessert?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Opal" || p5 == "opal")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Opal\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("what Washington State volcano erupted, killing more than 50 people and darkening the skies for hundreds of miles?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Mount St. Helen" || p6 == "mount st. helen" || p6 == "Mount Saint Helen" || p6 == "mount saint helen")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mount St. Helen\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("what country is considered \"The Heart of Motorsports\"?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "U.K." || p7 == "u.k." || p7 == "united kingdom" || p7 == "United Kingdom")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"U.K. or United Kingdom\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("Known as a mining powerhouse, what country is frequently the world's top annual producer of chrome, manganese, platinum, and vanadium?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "South africa" || p8 == "south africa" || p8 == "South Africa")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"South Africa\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("What is the people of new zealand called Formally?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "New zealanders" || p9 == "new zealanders")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"New zealanders\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("Which is colder North Pole or South Pole?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "South Pole" || p10 == "South pole" || p10 == "south pole")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"South Pole\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("What is the name of the supercontinent that existed millions of years ago?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Pangea" || p11 == "pangea")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Pangea\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("What city is known as \"Eternal City\"?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Rome" || p12 == "rome")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Rome\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("What do you call smaller rivers that flow into another river?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Tributares" || p13 == "tributares")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Tributares\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What is the name of the only tropical rainforest in the United States");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Puerto Rico’s El Yunque National Forest" || p14 == "puerto rico’s el yunque national forest")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Puerto Rico's El Yunque National Forest\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What is the driest continent on Earth?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "Antartica" || p15 == "antartica")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Antartica\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }






//Questions------------------------------------------------------------------------------------------------------------------------------------

    //NEW DIFF

        static void HEasy()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("Who created Spider-man?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Stan Lee" || p1 == "stan lee" || p1 == "Stan lee")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Stan Lee\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("What is the name of the superhero From DC that wears a bat outfit?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Batman" || p2 == "batman")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Batman\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("Who played Jack in The 1997 Titanic movie?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Leonardo DiCaprio" || p3 == "leonardo dicaprio" )
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Leonardo DiCaprio\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Who is the Philippines' National Hero?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Dr. Jose Rizal" || p4 == "dr. jose rizal" || p4 == "Jose Rizal" || p4 == "jose rizal")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Dr. Jose Rizal\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("Who Painted the infamous Monalisa?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Leonardo DaVinci" || p5 == "leonardo davinci")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Leonardo DaVinci\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("Who Composed the Fur elise?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Ludwig Van Beethoven" || p6 == "ludwig van beethoven" || p6 == "Beethoven" || p6 =="beethoven")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ludwig Van Beethoven\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("Who wears a red suit and has a white beard, often seen during chirstmas?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Santa Claus" || p7 == "Santa claus" || p7 == "santa claus")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Santa Claus\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("Who ruled as Emperor of the French from 1804 to 1814?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Napoleon Bonaparte" || p8 == "napoleon bonaparte" || p8 =="Napoleon" || p8 == "napoleon")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Napoleon Bonaparte\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("who invented the telephone?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Alexander Graham Bell" || p9 == "alexander graham bell")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Alexander Graham Bell\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("Who is the main character of \"Le Morte d'Arthur\" a british fiction about king of britain?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "King Arthur" || p10 == "king arthur")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"King Arthur\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Who is the author of Harry potter book series?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "J.K. Rowling" || p11 == "jk rowling")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"J.K. Rowling\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("who formulated the e=mc^2?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Albert Einstein" || p12 == "albert einstein" || p12 == "Einstein" || p12 == "einstein")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Albert Einstein\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("What is the name of the god of sun in egypt?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Ra" || p13 == "ra")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ra\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("Who is known as the All Father of norse mythology?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Odin" || p14 == "odin")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Odin\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What do we call a person who is a leader of the country?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "President" || p15 == "president")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"President\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }

        static void HNormal()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("Who is known as the asia's greatest conqueror?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Genghis Khan" || p1 == "genghis khan")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Genghis Khan\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("who quoted \"It does not matter how slow you go as long as you don't stop\"?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Confucius" || p2 == "confucius")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Confuscius\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("Who was known as the Maid of Orléans?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Joan of Arc" || p3 == "joan of arc" )
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Joan of Arc\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("What is the name of the egyptian God of Death?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Anubis" || p4 == "anubis")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Anubis\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("Who invented the guillotine?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Joseph-Ignace Guillotin" || p5 == "joseph-ignace guillotin")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Joseph-Ignace Guillotin\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("Who is known as the first king of qin dynasty and titled as \"king of all kings\n?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Qin Shi Huang" || p6 == "qin shi huang")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Qin Shi Huang\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("Who is the national hero of South africa?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Nelson Mandela" || p7 =="nelson mandela")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Nelson Mandela\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("What do they call a leader during ancient egypt?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Pharaoh" || p8 == "pharaoh")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Pharaoh\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("Who quoted\"Cogito, ergo sum\"?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Rene Descartes" || p9 == "rene descartes")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Rene Descartes\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("from greek mythology, who is known to carry the heavens as his punishment?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "Atlas" || p10 == "atlas")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Atlas\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Which norse god is known for having immense knowledge and wisdom?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Mimir" || p11 == "mimir")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mimir\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("Who made the very first car in the world?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Karl Benz" || p12 == "karl benz")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Karl Benz\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("Which philippine national hero is also known as sublime paralytic?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Bangkok" || p13 == "bangkok")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Bangkok\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("Which Philippine General is known for \"never winning a major battle\" during philippine-american war?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Antonio Luna" || p14 == "antonio luna")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Antonio Luna\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("Where is the smallest bone located in our body?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "ear" || p15 == "Ear")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ear\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }
        static void HHard()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("Which beethoven's song was created to be easy for the composer's love interest, later reworked so that she can't play it?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "fur elise" || p1 == "fur elise")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"fur elise\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("who is known as the \"last queen of france\"?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Marie Antoinette" || p2 == "marie antoinette")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Marie Antoinette\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What is the largest organ of a human?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "the skin" || p3 == "The Skin" || p3 == "skin" || p3 == "Skin")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"The Skin\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Which body part is responsible for filtering?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Liver" || p4 == "liver")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Liver\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("What is the term for \"fear of clowns\"?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Coulrophobia" || p5 == "coulrophobia")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Coulrophobia\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("Which body part is located near intestines and can be removed without having a problem?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Appendix" || p6 == "appendix")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Appendix\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("Who wrote \"Die Verwandlung\"?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Franz Kafka" || p7 == "franz kafka")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Franz Kafka\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("Which body part holds the body together?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Connective Tissue" || p8 == "connective tissue")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Connective Tissue\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("Which conqueror is known as king of macedonia?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Alexander the Great" || p9 == "alexander the great")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Alexander the Great\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("What do you call a man who draws a map?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "Cartographer" || p10 == "cartographer")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Cartographer\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Who is the philospher known as \"The Dog\"?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Diogenes" || p11 == "Diogenes")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Diogenes\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("What body part is called \"the most hardworking organ\"?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Heart" || p12 == "heart" || p12 == "The Heart" || p12 == "The heart" || p12 == "the heart")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Heart\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("Who wrote \"Hamlet\"?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "William Shakespeare" || p13 == "william shakespeare")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"William Shakespeare\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What is the \"fear of small holes or repititive pattern\" called?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Trypophobia" || p14 == "trypophobia")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"trypophobia\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What is the \"fear of long words\" called?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "Hippopotomonstrosesquippedaliophobia" || p15 == "hippopotomonstrosesquippedaliophobia")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Hippopotomonstrosequippedaliophobia\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }






//----------------------------------------------------------------------------------------------------------------------------------------------

    //NEW DIFF


        static void AEasy()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("What animal is considered as \"Man's bestfreind\"?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Dog" || p1 == "dog")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Dog\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("What fish is famous for its orange and white colour?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Clownfish" || p2 == "clownfish")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Clownfish\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What animal was used for transportation and often seen racing?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Horse" || p3 == "horse")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Horse\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("What do you call an animal that produce milk?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Mammals" || p4 == "mammals")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mammals\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("What animal have 4 hands, starts with \"M\"?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Monkey" || p5 == "monkey")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Monkey\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("What animal is considered as \"king of the jungle\"?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "Lion" || p6 == "lion")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Lion\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("What animal is seen in the logo of Lamborghini?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Bull" || p7 == "bull")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Bull\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("What is the fastest land animal?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Cheetah" || p8 == "cheetah")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Cheetah\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("What is known to be the most friendly and social nature animal?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "Capybara" || p9 == "capybara")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Capybara\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("Which animal is known for having a \"Long neck\"?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "giraffe" || p10 == "Giraffe")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Giraffe\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("In the movie Hachi, What kind of dog was Hachiko?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Shiba Inu" || p11 == "shiba inu")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Shiba Inu\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //12
            Console.Clear();
            Console.WriteLine("In the zodiac animals, which among them is not real?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Dragon" || p12 == "dragon")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Dragon\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("What animal is stated to be closer to Dinosaurs?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Birds" || p13 == "birds")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Birds\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("In the movie Alice in the wonderland, what animal is always following alice?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Rabbit" || p14 == "rabbit")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Rabbit\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What animal is a domestic feline?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "cat" || p15 == "Cat")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Cat\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        
        }

        static void ANormal()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("What is the scientific name for western gorilla?");
            Console.Write("");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Gorilla Gorilla" || p1 == "gorilla gorilla")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Gorilla Gorilla\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("What animal can be seen in a 50 peso philippine bank note?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Visayan leopard" || p2 == "visayan leopard" || p2 == "Visayan Leopard")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Visayan leopard\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What bird was associated with Aphrodite and used as a universal symbol of love and peace?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Doves" || p3 == "doves" || p3 == "Dove" || p3 == "dove")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Doves\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Which mammal animal can't jump?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Elephants" || p4 == "elephants" || p4 == "elephant" || p4 == "Elephant")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Elephant\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("What type of animal is a frog?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Amphibian" || p5 == "amphibian")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Amphibian\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("What is baby kangaroo called?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "joey" || p6 == "Joey")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Joey\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("Which mammal is known for having the thhickest fur?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Sea Otter" || p7 == "sea otter" || p7 == "Sea otter")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Sea Otters\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("What reptile can change color?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Chameleon" || p8 == "chameleon")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Chameleon\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("Which farm animal use their ears positioning to communicate their emotions?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "sheep" || p9 == "Sheep")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Sheep\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("What color are flamingos when they are born?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "grey" || p10 == "Grey")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Grey\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("What do Pandas eat mostly?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Bamboo" || p11 == "bamboo")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Bambbo\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("How many hearts do Octupus have?");
            Console.Write($"");
            string p12 = Console.ReadLine();

            if (p12 == "three" || p12 == "Three" || p12 == "3")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Three(3)\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("Which bird is known for its ability to mimic human speech?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Parrot" || p13 == "parrot")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Parrot\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What do you call a group of crows?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Murder" || p14 == "murder")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Murder\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("What mammal is capable of flying?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "Bat" || p15 == "cat")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Bat\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }

        static void AHard()
        {
            Console.Clear();

            int b = 0;
            int c = 0;
            Console.WriteLine("How many tentacles does a squid have?");
            Console.Write($"");
            string p1 = Console.ReadLine();

            //1
            if (p1 == "Two" || p1 == "two" || p1 == "2")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Two(2)\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //2
            Console.Clear();
            Console.WriteLine("What is the scientific name for crocodile?");
            Console.Write("");
            string p2 = Console.ReadLine();

            if (p2 == "Crocodylus" || p2 == "crocodylus")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Crocodylus\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //3
            Console.Clear();
            Console.WriteLine("What animal is known for being able to climb steepest obstacles?");
            Console.Write("");
            string p3 = Console.ReadLine();

            if (p3 == "Mountain Goat" || p3 == "mountain goat" || p3 == "Mountain goat")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Mountain Goat\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //4
            Console.Clear();
            Console.WriteLine("Which animal produce pink milk?");
            Console.Write("");
            string p4 = Console.ReadLine();

            if (p4 == "Hippo" || p4 == "Hippopotamus" || p4 == "hippo" || p4 == "hippopotamus")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Hippopotamus or Hippo\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //5
            Console.Clear();
            Console.WriteLine("Which animal is capable of laying eggs, males are venomous and glows when under UV light?");
            Console.Write("");
            string p5 = Console.ReadLine();

            if (p5 == "Platypus" || p5 == "platypus")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Platypus\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //6
            Console.Clear();
            Console.WriteLine("What insect do we harvest fibers from?");
            Console.Write("");
            string p6 = Console.ReadLine();

            if (p6 == "silkworm" || p6 == "Silkworm")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Silkworm\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }


            //7
            Console.Clear();
            Console.WriteLine("Which canine animal can smell their prey for about 2 miles away?");
            Console.Write("");
            string p7 = Console.ReadLine();

            if (p7 == "Dog" || p7 == "dog" || p7 == "wolves" || p7 == "Wolves")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Dogs or Wolves\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //8
            Console.Clear();
            Console.WriteLine("What bird is considered the smartest bird?");
            Console.Write("");
            string p8 = Console.ReadLine();

            if (p8 == "Crow" || p8 == "crow" || p8 == "Crows" || p8 == "crows")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Crow(s)\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //9
            Console.Clear();
            Console.WriteLine("What animal is used for connecting wires by tying it to them and goes through tight spaces?");
            Console.Write("");
            string p9 = Console.ReadLine();

            if (p9 == "ferret" || p9 == "Ferret")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Ferret\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //10
            Console.Clear();
            Console.WriteLine("Which insect does male insect's head gets eaten after or during mating process?");
            Console.Write("");
            string p10 = Console.ReadLine();

            if (p10 == "Praying Mantis" || p10 == "praying mantis" || p10 == "Praying mantis")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Praying Mantis\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //11
            Console.Clear();
            Console.WriteLine("Which type of rodent is known for having a sense of humour?");
            Console.Write("");
            string p11 = Console.ReadLine();

            if (p11 == "Rat" || p11 == "rat")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Rat\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //12
            Console.Clear();
            Console.WriteLine("What is the scientific name of snakes?");
            Console.Write("");
            string p12 = Console.ReadLine();

            if (p12 == "Serpentes" || p12 == "serpentes")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Serpentes\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //13
            Console.Clear();
            Console.WriteLine("What is the scientific name for western lowland gorilla?");
            Console.Write("");
            string p13 = Console.ReadLine();

            if (p13 == "Gorilla gorilla gorilla" || p13 == "gorilla gorilla gorilla" || p13 == "Gorilla Gorilla Gorrila" || p13 == "Gorilla Gorilla gorilla")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Gorilla Gorilla Gorilla\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;
            }

            //14
            Console.Clear();
            Console.WriteLine("What mythological creature is feared at the sea?");
            Console.Write("");
            string p14 = Console.ReadLine();

            if (p14 == "Kraken" || p14 == "kraken")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Kraken\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            //15
            Console.Clear();
            Console.WriteLine("Which fish holds the title of \"dumbest fish\"?");
            Console.Write("");
            string p15 = Console.ReadLine();

            if (p15 == "sunfish" || p15 == "Sunfish")
            {
                Console.WriteLine("\n\nCorrect!");
                Console.Write("press any to continue...");
                Console.ReadKey();
                b = b + 1;
            }
            else
            {
                Console.WriteLine("\n\nWrong! the correct answer is \"Sunfish\"");
                Console.Write("press any to continue..");
                Console.ReadKey();
                c = c + 1;

            }

            Console.Clear();
            Correct = b + Wrong;
            Wrong = c + Wrong;
            Console.WriteLine("You finished the question now to show the results!");
            Console.ReadKey();
            Result();
        }
        
        static void Result()
        {
            Console.WriteLine("Here are your results");
            Console.WriteLine($"Correct Answers : {Correct}");
            Console.WriteLine($"Wrong Answers : {Wrong}");

            if (Correct == 15)
            {
                Console.WriteLine($"Congratulations! You got the perfect score, {Correct} out of 15");
                Console.WriteLine("Enter X to go to main menu or any key to exit");
                Console.Write("\n\n");
                string x = Console.ReadLine();
                    if (x == "x" || x == "X")
                {
                    MainMenu();
                }
            }
            else if (Correct <= 14 && Correct >= 8)
            {
                Console.WriteLine($"You did great! {Correct} out of 15");
                Console.WriteLine("Enter X to go to main menu or any key to exit");
                Console.Write("\n\n");
                string x = Console.ReadLine();
                if (x == "x" || x == "X")
                {
                    MainMenu();
                }
            }
            else if (Correct <= 7 && Correct >= 4)
            {
                Console.WriteLine($"Need more improvements,{Correct} out of 15");
                Console.WriteLine("Enter X to go to main menu or any key to exit");
                Console.Write("\n\n");
                string x = Console.ReadLine();
                if (x == "x" || x == "X")
                {
                    MainMenu();
                }
            }
            else if (Correct <= 3 && Correct == 1)
            {
                Console.WriteLine($"Poor Performance need improvements, {Correct} out of 15");
                Console.WriteLine("Enter X to go to main menu or any key to exit");
                Console.Write("\n\n");
                string x = Console.ReadLine();
                if (x == "x" || x == "X")
                {
                    MainMenu();
                }
            }
            else if (Correct == 0){
                Console.WriteLine($"No correct answer, {Correct} out of 15");
                Console.WriteLine("Enter X to go to main menu or any key to exit");
                Console.Write("\n\n");
                string x = Console.ReadLine();
                if (x == "x" || x == "X")
                {
                    MainMenu();
                }

            }
        }
    }
}
