using System;
using System.Collections.Generic;

namespace CountryTagExtractor
{
    class Country
    {
        public string[] Name { get; set; }
        public string[] Cities { get; set; }

        public Dictionary<string, int> CitiesMentions { get; } = new Dictionary<string, int>();
        public Dictionary<string, int> CountryMentions { get; } = new Dictionary<string, int>();

        public int Coefficient { get; set; } = 0;

        public Country(string[] name, string[] cities)
        {
            Name = name;
            Cities = cities;
        }

        public void СalculateСoefficient()
        {
            foreach (int number in CitiesMentions.Values)
                Coefficient += number;
            foreach (int number in CountryMentions.Values)
                Coefficient += number;
        }
    }
}
