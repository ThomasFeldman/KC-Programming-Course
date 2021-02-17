using System;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfMonth = 1;
            
            //June While Loop
            while (dayOfMonth < 31) {
                Console.WriteLine("June " + dayOfMonth);
                dayOfMonth++;
            }

            Console.ReadLine();
            //December Do-While Loop
            dayOfMonth = 1;

            do
            {
                Console.WriteLine("December " + dayOfMonth);
                dayOfMonth++;
            } while (dayOfMonth < 32);

            //March For Loop
            dayOfMonth = 1;

            for(int i = dayOfMonth; i < 32; i++)
            {
                Console.WriteLine("March " + i);
            }

            Console.ReadLine();
        }
    }
}
