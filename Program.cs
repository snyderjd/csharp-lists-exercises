using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ========== Practice: Planet and Spaceships ==========
            List<string> planetList = new List<string>(){ "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){ "Uranus", "Neptune" };

            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            // string[] output = dinosaurs.GetRange(2, 3).ToArray();

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            // Console.WriteLine("planetList");
            // foreach (string planet in planetList) 
            // {
            //     Console.WriteLine(planet);
            // }

            // Print lists to the console
            // planetList.ForEach(Console.WriteLine);
            // rockyPlanets.ForEach(Console.WriteLine);

            // ========== Practice: Random Numbers ==========
            Random random = new Random();

            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6)
            };

            for (int i = 0; i < numbers.Count; i++) {
                // Determine if the current loop index is contained inside of the 'numbers' list. Print a message to the console indicating whether or not the index is on the list
                if (numbers.Contains(i)) {
                    Console.WriteLine($"numbers list contains {i}");
                } else {
                    Console.WriteLine($"numbers list does not contain {i}");
                }
            }
        }
    }
}


