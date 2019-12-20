using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int charNum = input;
            if(charNum>=65 && charNum<=90)
            {
                Console.WriteLine("upper-case");
            }
            else if(charNum >= 97 && charNum <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
