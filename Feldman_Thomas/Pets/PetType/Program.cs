using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetType
{
    class Program
    {
        static void Main(string[] args)
        {
            string dog = "N";
            string cat = "N";
            string other = "N";

            Console.WriteLine("Do you have a dog (Y/N)?");
            if (Console.ReadLine() == "Y") {
                dog = "Y";
            }

            Console.WriteLine("Do you have a cat (Y/N)?");
            if (Console.ReadLine() == "Y")

            {
                cat = "Y";
            }

            Console.WriteLine("Do you have other types of pets (Y/N)?");
            if (Console.ReadLine() == "Y")
            {
                other = "Y";
            }


            if (dog == "Y")
            {
                Console.WriteLine("Congratulations on your pet dog!");
            }

            if (cat == "Y")
            {
                Console.WriteLine("Say hello to your kitty from Thomas");
            }

            if (other == "Y")
            {
                Console.WriteLine("Your pet must be interesting!");
            }

            Console.ReadLine();
        }
    }
}
