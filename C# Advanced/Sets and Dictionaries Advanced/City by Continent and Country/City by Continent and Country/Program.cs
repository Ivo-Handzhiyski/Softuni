using System;
using System.Collections.Generic;
using System.Linq;
namespace City_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var parts = line.Split(" ");
                var continentName = parts[0];
                var countryName = parts[1];
                var townName = parts[2];

                if(!continents.ContainsKey(continentName))
                {
                    continents.Add(continentName, new Dictionary<string, List<string>>());

                }

                var continent = continents[continentName];

                if(!continent.ContainsKey(countryName))
                {
                    continent.Add(countryName, new List<string>());

                }

                var country = continent[countryName];

                if(!country.Contains(townName))
                {
                    country.Add(townName);

                }              
         }


            foreach (var continent in continents)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }

        }
    }
}
