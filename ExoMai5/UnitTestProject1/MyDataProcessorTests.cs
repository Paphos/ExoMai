using ExoMai5;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class MyDataProcessorTests
    {
        private MyDataProcessor _myDataProcessor;

        public MyDataProcessorTests()
        {
            var deserializer = new CityCsvDeserializer("villes_france.csv");
            var cities = deserializer.ReadCities();
            _myDataProcessor = new MyDataProcessor(cities);
        }


        // *****************************************************************************
        // *******************             LEVEL 1               ***********************
        // *******************        (one Linq method)          ***********************
        // *****************************************************************************

        [Fact]
        public void GetTotalPopulation()
        {
            int totalPopulation = _myDataProcessor.GetTotalPopulation();
            Assert.Equal(60337171, totalPopulation);
        }

        [Fact]
        public void GetCitiesStartingWithSaint()
        {
            IEnumerable<City> citiesStartWithSaint = _myDataProcessor.GetCitiesStartingWithSaint();
            Assert.Equal(4260, citiesStartWithSaint.Count());
            Assert.Contains(citiesStartWithSaint, city => city.Name == "Saint-Étienne");
        }

        [Fact]
        public void IsThereACityThatHasExactly10000Inhabitants()
        {
            Assert.False(_myDataProcessor.IsThereACityThatHasExactly10000Inhabitants());
        }



        // *****************************************************************************
        // *******************             LEVEL 2               ***********************
        // *******************        (two Linq methods)         ***********************
        // *****************************************************************************

        [Fact]
        public void GetTheCityWithTheLongestName()
        {
            City cityWithTheLongestName = _myDataProcessor.GetTheCityWithTheLongestName();
            Assert.Equal("Saint-Remy-en-Bouzemont-Saint-Genest-et-Isson", cityWithTheLongestName.Name);
        }

        [Fact]
        public void GetThe10MostPopulatedFrenchCities()
        {
            IEnumerable<City> mostPopulatedCities = _myDataProcessor.GetThe10MostPopulatedFrenchCities();
            Assert.Equal(10, mostPopulatedCities.Count());
            Assert.Contains(mostPopulatedCities, city => city.Name == "Paris");
        }

        [Fact]
        public void GetAllDepartments()
        {
            IEnumerable<string> allDepartments = _myDataProcessor.GetAllDepartments();
            Assert.Equal(102, allDepartments.Count());
            Assert.Contains("2A", allDepartments);
        }

        [Fact]
        public void GetNumberOfCityInCorsica()
        {
            int numberOfCityInCorsica = _myDataProcessor.GetNumberOfCityInCorsica();
            Assert.Equal(360, numberOfCityInCorsica);
        }



        // *****************************************************************************
        // *******************             LEVEL 3               ***********************
        // *******************   (three or more Linq methods)    ***********************
        // *****************************************************************************


        [Fact]
        public void GetAllDuplicateCityNames()
        {
            IEnumerable<string> duplicateCityNames = _myDataProcessor.GetAllDuplicateCityNames();
            Assert.Equal(1685, duplicateCityNames.Count());
            Assert.Contains("Moulins", duplicateCityNames);
        }

        [Fact]
        public void GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities()
        {
            int numberOfPeopleThatDontLiveInThe10BiggestCities
                = _myDataProcessor.GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities();
            Assert.Equal(55053768, numberOfPeopleThatDontLiveInThe10BiggestCities);
        }

        [Fact]
        public void GetThe3BiggestAndThe3SmallestCities()
        {
            IEnumerable<City> theBiggestAndSmallestCities = _myDataProcessor.GetThe3BiggestAndThe3SmallestCities();
            Assert.Equal(6, theBiggestAndSmallestCities.Count());
            Assert.Contains(theBiggestAndSmallestCities, city => city.Name == "Paris");
            Assert.Contains(theBiggestAndSmallestCities, city => city.Name == "Rochefourchat");
        }

        [Fact]
        public void GetTheMostPopulatedDepartment()
        {
            string mostPopulatedDepartment = _myDataProcessor.GetTheMostPopulatedDepartment();
            Assert.Equal("59", mostPopulatedDepartment);
        }
    }
}
