﻿using System;
class Program
{
    static void Main()
    {
        // Input temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        // Conversion formula
        double fahrenheit = (celsius * 9 / 5) + 32;
        // Output result
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }
}