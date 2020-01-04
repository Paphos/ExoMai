using System;
using System.Collections.Generic;

namespace ExoMai2
{
    public static class CityCountryMapping
    {
        private static Dictionary<string, string> _singletonDictionary;

        public static Dictionary<string, string> GetDictionary()
        {
            if (_singletonDictionary == null)
            {
                _singletonDictionary = new Dictionary<string, string>()
                {
                    ["London"] = "United Kingdom",
                    ["Moscow"] = "Russia",
                    ["Tokyo"] = "Japan",
                    ["Kyoto"] = "Japan",
                    ["Hanoi"] = "Vietnam",
                    ["Mumbai"] = "India",
                    ["Lyon"] = "France",
                    ["Paris"] = "France",
                    ["Los Angeles"] = "USA",
                    ["Seattle"] = "USA",
                    ["New York"] = "USA",
                    ["Berlin"] = "Germany",
                    ["Stuttgart"] = "Germany",
                    ["Seoul"] = "South Korea",
                    ["Brazilia"] = "Brazil",
                    ["Geneva"] = "Switzerland",
                    ["Dublin"] = "Ireland",
                    ["Toronto"] = "Canada",
                    ["Stockholm"] = "Sweden",
                };
            }

            return _singletonDictionary;
        }
    }
}
