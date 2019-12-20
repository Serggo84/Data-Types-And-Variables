using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, heigth = 0;
            double sum=0;
            Console.WriteLine("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Heigth: ");
            heigth = double.Parse(Console.ReadLine());
            sum = (length + width + heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {sum:f2}");

        }
    }
}
