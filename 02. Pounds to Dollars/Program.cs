﻿using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());
            double dollar = pound * 1.31;
            Console.WriteLine($"{dollar:f3}");
        }
    }
}
