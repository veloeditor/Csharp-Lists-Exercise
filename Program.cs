using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");

            Console.WriteLine();
            foreach( string planet in planetList )
                {
                    Console.WriteLine(planet);
                }

            List<string> planetListTwo = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(planetListTwo);
            planetList.Add("Pluto");

            Console.WriteLine();
            foreach( string planet in planetList )
                {
                    Console.WriteLine(planet);
                }
            planetList.Remove("Pluto");

            Console.WriteLine();
            foreach( string planet in planetList )
                {
                    Console.WriteLine(planet);
                }
            
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
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
