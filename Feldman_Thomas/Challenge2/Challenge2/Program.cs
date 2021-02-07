using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            char userVar;


            Console.WriteLine("Enter in a char from a-z");
            userVar = Convert.ToChar(Console.ReadLine().ToLower());


            switch (userVar) {
                case 'a':
                    Console.WriteLine("Alpha");
                    break;
                case 'b':
                    Console.WriteLine("Bravo");
                    break;
                case 'c':
                    Console.WriteLine("Charlie");
                    break;
                case 'd':
                    Console.WriteLine("Delta");
                    break;
                case 'e':
                    Console.WriteLine("Echo");
                    break;
                case 'f':
                    Console.WriteLine("Foxtrot");
                    break;
                case 'g':
                    Console.WriteLine("Golf");
                    break;
                case 'h':
                    Console.WriteLine("Hotel");
                    break;
                case 'i':
                    Console.WriteLine("India");
                    break;
                case 'j':
                    Console.WriteLine("Juliett");
                    break;
                case 'k':
                    Console.WriteLine("Kilo");
                    break;
                case 'l':
                    Console.WriteLine("Lima");
                    break;
                case 'm':
                    Console.WriteLine("Mike");
                    break;
                case 'n':
                    Console.WriteLine("November");
                    break;
                case 'o':
                    Console.WriteLine("Oscar");
                    break;
                case 'p':
                    Console.WriteLine("Papa");
                    break;
                case 'q':
                    Console.WriteLine("Quebec");
                    break;
                case 'r':
                    Console.WriteLine("Romeo");
                    break;
                case 's':
                    Console.WriteLine("Sierra");
                    break;
                case 't':
                    Console.WriteLine("Tango");
                    break;
                case 'u':
                    Console.WriteLine("Uniform");
                    break;
                case 'v':
                    Console.WriteLine("Victor");
                    break;
                case 'w':
                    Console.WriteLine("Whiskey");
                    break;
                case 'x':
                    Console.WriteLine("Xray");
                    break;
                case 'y':
                    Console.WriteLine("Yankee");
                    break;
                case 'z':
                    Console.WriteLine("Zulu");
                    break;
                default:
                    Console.WriteLine("Character entered wasn’t between a and z.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
