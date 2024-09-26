using System;
{
 static void Main()
    {
        //, Classmate names and ages
        string[] names = { "Keegan", "Ahamed", "Camilo", "Kat", "Lucas", "Lucas", "Mason", "Bruno", "Ethan", "Sean", "Ali", "Burak", "Eren", "Can" };
        int[] ages = { 18, 23, 19, 27, 29, 23, 24, 25, 26, 21, 35, 29, 28, 31 };
        // Seven famous cities
        string[] cities = { "Istanbul", "Paris", "New York", "Tokyo", "London", "Sydney", "Ankara" };
        // Display classmates and their ages
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i] + " is " + ages[i] + " years old.");
        }
        // Display the cities
        Console.WriteLine("\nFamous Cities:");
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine(cities[i]);
        }
    }
}
