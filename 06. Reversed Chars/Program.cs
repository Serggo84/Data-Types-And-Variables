using System;

namespace _6._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secndChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            Console.Write($"{thirdChar} {secndChar} {firstChar}");
        }
    }
}
