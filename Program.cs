using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // Console.WriteLine("rockyPlanets");
            // foreach(string planet in rockyPlanets)
            // {
            //     Console.WriteLine(planet);
            // }

            // planetList.Remove("Pluto");

            // Console.WriteLine("planetList");
            // foreach(string planet in planetList)
            // {
            //     Console.WriteLine(planet);
            // }

            // Print lists to the console
            planetList.ForEach(Console.WriteLine);
            rockyPlanets.ForEach(Console.WriteLine);
        }
    }
}

