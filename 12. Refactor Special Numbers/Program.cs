using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            bool input = false;
            for (int number = 1; number <= n; number++)
            {
                int digits = number;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }
                input = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", digits, input);
                sumOfDigits = 0;
                number = digits;
            }

        }
    }
}
