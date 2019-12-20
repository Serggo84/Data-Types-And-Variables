using System;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int digits = i;
                bool? input =null;
                while(digits>0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
                if (sum == 5 || sum==7 || sum==11)
                {
                    input = true;
                }
                else
                {
                    input = false;
                }
                Console.WriteLine($"{i} -> {input}");
            }
        }
    }
}
