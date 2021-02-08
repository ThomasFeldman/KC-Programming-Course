using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int petNo = 0;

            Console.WriteLine("How many pets do you have?");
            petNo = Convert.ToInt32(Console.ReadLine());

            switch (petNo)
            {
                case 0:
                    Console.WriteLine("Maybe you will get some pets someday soon!");
                    break;
                case 1:
                    Console.WriteLine("Say hello to your special friend from Thomas!");
                    break;
                case 2:
                    Console.WriteLine("Two is a nice number of pets!");
                    break;
                case 3:
                    Console.WriteLine("You must really like pets!");
                    break;
                case 4:
                    Console.WriteLine("Four is a lot of pets!");
                    break;
                default:
                    if (petNo < 0){
                        Console.WriteLine("That's not a valid number of pets!");
                    }
                    else {
                        Console.WriteLine("You have so many pets!");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
