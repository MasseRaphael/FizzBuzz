using System;

namespace FizzBuzz
{
    class Program
    {
        public static void Main()
        {
            int compte = 1;

            do
            {
                if (compte % 3 == 0 && compte % 5 == 0)
                {
                    Console.WriteLine(compte + "FizzBuzz");
                }
                else if (compte % 5 == 0)
                {
                    Console.WriteLine(compte + "Buzz");
                }
                else if (compte % 3 ==0)
                {
                    Console.WriteLine(compte + "Fizz");
                }
                else
                {
                   Console.WriteLine(compte); 
                }
                compte = compte + 1;
            } while (compte <= 200);
        }
    }
}
