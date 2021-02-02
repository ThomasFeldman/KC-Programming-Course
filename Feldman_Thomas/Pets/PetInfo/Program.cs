using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare vars
            string petName = "Fido";
            string humanName = "Tim Smith";
            int petAge;
            int humanAge;
            
            //First print statement
            Console.WriteLine( humanName + " has a pet named " + petName + ".");
          
            //Enter Human’s age:  
            Console.WriteLine("Enter " + humanName + "'s age: ");
            humanAge = int.Parse(Console.ReadLine());
            
            //Enter Pet's age
            Console.WriteLine("Enter " + petName + "'s age: ");
            petAge = int.Parse(Console.ReadLine());

            //Display and wait
            Console.WriteLine(humanName + " is " + humanAge + " years old and the pet "
                + petName + " is " + petAge + " years old.");
            Console.ReadLine();
        }
    }
}
