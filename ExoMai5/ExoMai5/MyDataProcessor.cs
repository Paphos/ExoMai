using System;
using System.Collections.Generic;

namespace ExoMai5
{
    public class MyDataProcessor
    {
        private IEnumerable<City> _cities;

        public MyDataProcessor(IEnumerable<City> cities)
        {
            _cities = cities;
        }

        // *****************************************************************************
        // *******************             LEVEL 1               ***********************
        // *******************        (one Linq method)          ***********************
        // *****************************************************************************

        /// <summary>
        /// Get the total population of France, meaning the sum of the population of every french city.
        /// </summary>
        public int GetTotalPopulation()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// Get a list of all the french cities that starts with "Saint" like "Saint-Etienne" or "Saint-Germain-des-Prés"
        /// </summary>
        public IEnumerable<City> GetCitiesStartingWithSaint()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// Is there a city that has exactly 10000 inhabitants ?
        /// </summary>
        public bool IsThereACityThatHasExactly10000Inhabitants()
        {
            throw new NotImplementedException("To be completed!");
        }



        // *****************************************************************************
        // *******************             LEVEL 2               ***********************
        // *******************        (two Linq methods)         ***********************
        // *****************************************************************************


        /// <summary>
        /// What is the french city that has the longest name ?
        /// </summary>
        public City GetTheCityWithTheLongestName()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// What are the 10 most populated french cities ?
        /// </summary>
        public IEnumerable<City> GetThe10MostPopulatedFrenchCities()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// Get the list of all french departments
        /// </summary>
        public IEnumerable<string> GetAllDepartments()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// How many cities are there in the Corsica island (= departements 2A and 2B) ?
        /// </summary>
        public int GetNumberOfCityInCorsica()
        {
            throw new NotImplementedException("To be completed!");
        }



        // *****************************************************************************
        // *******************             LEVEL 3               ***********************
        // *******************   (three or more Linq methods)    ***********************
        // *****************************************************************************


        /// <summary>
        /// Get all names that were given to multiple city.
        /// For example, "Moulins" can be three different cities :
        ///     - one in the "Allier" department
        ///     - one in the "Aisne" department
        ///     - and one in the "Ille-et-Vilaine" department
        /// </summary>
        public IEnumerable<string> GetAllDuplicateCityNames()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// How many french people are living outside of the 10 biggest cities ?
        /// </summary>
        public int GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// Get in the same list the 3 cities with the highest population and the 3 cities with the lowest population.
        /// WARNING !!! You must exclude the cities that have 0 inhabitants as these are probably errors in the data.
        /// </summary>
        public IEnumerable<City> GetThe3BiggestAndThe3SmallestCities()
        {
            throw new NotImplementedException("To be completed!");
        }

        /// <summary>
        /// Get the code of the department that has the highest population
        /// </summary>
        public string GetTheMostPopulatedDepartment()
        {
            throw new NotImplementedException("To be completed!");
        }
    }
}
