using System;

/*
    Initial Developer: Thomas Feldman
    Initial Development Date: 02/22/2021
    Modification: 02/27/2021
 */

namespace Multiplication

{

    class Multiply
    {
        /*
         These methods call one another based on the number of integers passed in.
         The real work is done in the method receiving four integers.
         */

        //The real work is done here
        public static int Calculate(int numberOne, int numberTwo, int numberThree, int numberFour)
        {
            return numberOne * numberTwo * numberThree * numberFour;
        }
        //TODO This logic could be revised to use different variable names for both variables
        public static int Calculate(int numberOne, int numberTwo)
        {
            return Multiply.Calculate(numberOne, numberTwo, 1);
        }
        //TODO This logic could be revised to use different variable names for all three variables
        public static int Calculate(int numberOne, int numberTwo, int numberThree)
        {
            return Multiply.Calculate(numberOne, numberTwo, numberThree, 1);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int returnedValue = 1;
            int numOne = 2;
            int numTwo = 5;
            int numThree = 3;
            int numFour = 10;


            //Calling the Plus method without instantiating the Clas
            returnedValue = Multiply.Calculate(numOne, numTwo);
            Console.WriteLine(returnedValue);


            returnedValue = Multiply.Calculate(numOne, numTwo, numThree);
            Console.WriteLine(returnedValue);


            returnedValue = Multiply.Calculate(numOne, numTwo, numThree, numFour);
            Console.WriteLine(returnedValue);

            //TODO Come up with a way to list out the individual numbers which were added together to get this answer
            Console.ReadLine(); //Stops the Console awaiting input
        }
    }
}
/*
The math done in this program is utilized by calls from many applications.
Any modifications should include a full round of testing
*/