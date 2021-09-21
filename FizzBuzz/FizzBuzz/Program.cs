using System;

namespace FizzBuzz
{
    class Program
    {
        public static void Main()
        {
            int compte = 0;

            do
            {
                Console.Write($"{compte} ");
                if (compte % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (compte % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine("");
                compte ++;
            } while (compte <= 200);
        }
    }
}
