using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExoMai2
{
    public class Traveler
    {
        private List<string> _visitedCitiesList;

        public string Name { get; set; }
        public IEnumerable<string> VisitedCities => _visitedCitiesList;

        public Traveler(string name, params string[] visitedCities)
        {
            this.Name = name;
            _visitedCitiesList = visitedCities.ToList();
        }

        public void AddNewlyVisitedCity(string cityName)
        {
            _visitedCitiesList.Add(cityName);
        }
    }
}
