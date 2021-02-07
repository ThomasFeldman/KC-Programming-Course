using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;

            Console.WriteLine("Enter a Number: ");
            userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(NumberSize(userNum));

            Console.ReadLine();


        }

        static string NumberSize(int userNum) {

            string numSize;

            if (userNum < 100)
            {
                numSize = "small";
            }
            else
            {
                numSize = "big";
            }

            numSize = "The number is " + numSize;

            return numSize;
        }
    }
}
