using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdchar = char.Parse(Console.ReadLine());
            Console.WriteLine($"{firstChar}{secondChar}{thirdchar}");
        }
    }
}
