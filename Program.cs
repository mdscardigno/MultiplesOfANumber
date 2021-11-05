using System;

namespace MultiplesOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the multiples of the number 3 from 1 to 1000.");
            int number = 0;
            while (number <= 1000)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            Console.ReadKey();
        }
    }
}
