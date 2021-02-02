using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int petAge;

            Console.WriteLine("Enter the age of your dog: ");
            petAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your pet is " + DogYears(petAge) + " years old in dog years.");
            Console.WriteLine("Your pet is " + CatYears(petAge) + " years old in cat years.");
            Console.ReadLine();

        }

        public static int DogYears(int petAge)
        {
            int dogYears = petAge * 7;

            return dogYears;

        }

        public static int CatYears(int petAge)
        {
            int catYears = petAge * 4;

            return catYears;
        }
    }
}
