using ExoMai5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class MyDataProcessorTest
    {
        private MyDataProcessor _myDataProcessor;

        [TestInitialize]
        public void Initialize()
        {
            var deserializer = new CityCsvDeserializer("villes_france.csv");
            var cities = deserializer.ReadCities();
            _myDataProcessor = new MyDataProcessor(cities);
        }


        // *****************************************************************************
        // *******************             LEVEL 1               ***********************
        // *******************        (one Linq method)          ***********************
        // *****************************************************************************

        [TestMethod]
        public void GetTotalPopulation()
        {
            int totalPopulation = _myDataProcessor.GetTotalPopulation();
            Assert.AreEqual(60337171, totalPopulation);
        }

        [TestMethod]
        public void GetCitiesStartingWithSaint()
        {
            IEnumerable<City> citiesStartWithSaint = _myDataProcessor.GetCitiesStartingWithSaint();
            Assert.AreEqual(4260, citiesStartWithSaint.Count());
            Assert.IsTrue(citiesStartWithSaint.Any(city => city.Name == "Saint-Étienne"));
        }

        [TestMethod]
        public void IsThereACityThatHasExactly10000Inhabitants()
        {
            Assert.IsFalse(_myDataProcessor.IsThereACityThatHasExactly10000Inhabitants());
        }



        // *****************************************************************************
        // *******************             LEVEL 2               ***********************
        // *******************        (two Linq methods)         ***********************
        // *****************************************************************************

        [TestMethod]
        public void GetTheCityWithTheLongestName()
        {
            City cityWithTheLongestName = _myDataProcessor.GetTheCityWithTheLongestName();
            Assert.AreEqual("Saint-Remy-en-Bouzemont-Saint-Genest-et-Isson", cityWithTheLongestName.Name);
        }

        [TestMethod]
        public void GetThe10MostPopulatedFrenchCities()
        {
            IEnumerable<City> mostPopulatedCities = _myDataProcessor.GetThe10MostPopulatedFrenchCities();
            Assert.AreEqual(10, mostPopulatedCities.Count());
            Assert.IsTrue(mostPopulatedCities.Any(city => city.Name == "Paris"));
        }

        [TestMethod]
        public void GetAllDepartments()
        {
            IEnumerable<string> allDepartments = _myDataProcessor.GetAllDepartments();
            Assert.AreEqual(102, allDepartments.Count());
            Assert.IsTrue(allDepartments.Contains("2A"));
        }

        [TestMethod]
        public void GetNumberOfCityInCorsica()
        {
            int numberOfCityInCorsica = _myDataProcessor.GetNumberOfCityInCorsica();
            Assert.AreEqual(360, numberOfCityInCorsica);
        }



        // *****************************************************************************
        // *******************             LEVEL 3               ***********************
        // *******************   (three or more Linq methods)    ***********************
        // *****************************************************************************


        [TestMethod]
        public void GetAllDuplicateCityNames()
        {
            IEnumerable<string> duplicateCityNames = _myDataProcessor.GetAllDuplicateCityNames();
            Assert.AreEqual(1685, duplicateCityNames.Count());
            Assert.IsTrue(duplicateCityNames.Contains("Moulins"));
        }

        [TestMethod]
        public void GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities()
        {
            int numberOfPeopleThatDontLiveInThe10BiggestCities
                = _myDataProcessor.GetTheNumberOfFrenchPeopleThatDontLiveInThe10MostPopulatedCities();
            Assert.AreEqual(55053768, numberOfPeopleThatDontLiveInThe10BiggestCities);
        }

        [TestMethod]
        public void GetThe3BiggestAndThe3SmallestCities()
        {
            IEnumerable<City> theBiggestAndSmallestCities = _myDataProcessor.GetThe3BiggestAndThe3SmallestCities();
            Assert.AreEqual(6, theBiggestAndSmallestCities.Count());
            Assert.IsTrue(theBiggestAndSmallestCities.Any(city => city.Name == "Paris"));
            Assert.IsTrue(theBiggestAndSmallestCities.Any(city => city.Name == "Rochefourchat"));
        }

        [TestMethod]
        public void GetTheMostPopulatedDepartment()
        {
            string mostPopulatedDepartment = _myDataProcessor.GetTheMostPopulatedDepartment();
            Assert.AreEqual("59", mostPopulatedDepartment);
        }
    }
}
