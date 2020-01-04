using ExoMai2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class TravelerHelperTest
    {
        [TestMethod]
        public void GetNumberOfCountryVisitedByTravellers_HappyPath()
        {
            // Arrange
            List<Traveler> travelers = new List<Traveler>()
            {
                new Traveler("Sébastien", "Paris"),
                new Traveler("Clémence", "London", "Mumbai", "New York"),
                new Traveler("Antoine", "New York", "Tokyo"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(1, result["Sébastien"]);
            Assert.AreEqual(3, result["Clémence"]);
            Assert.AreEqual(2, result["Antoine"]);
        }

        [TestMethod]
        public void GetNumberOfCountryVisitedByTravellers_TravellerCanVisitZeroCountry()
        {
            // Arrange
            List<Traveler> travelers = new List<Traveler>()
            {
                new Traveler("Thomas"),
                new Traveler("Stéphanie", "Geneva", "Stockholm"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(0, result["Thomas"]);
            Assert.AreEqual(2, result["Stéphanie"]);
        }

        [TestMethod]
        public void GetNumberOfCountryVisitedByTravellers_TravellerCanVisitMultipleCitiesOfSameCountry()
        {
            // Arrange
            List<Traveler> travelers = new List<Traveler>()
            {
                new Traveler("Charlotte", "Paris", "Lyon", "Tokyo", "Geneva", "Kyoto"),
                new Traveler("James", "Mumbai", "Moscow"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(3, result["Charlotte"]);
            Assert.AreEqual(2, result["James"]);
        }

        [TestMethod]
        public void GetNumberOfCountryVisitedByTravellers_TravellerCanVisitMultipleTimesTheSameCity()
        {
            // Arrange
            List<Traveler> travelers = new List<Traveler>()
            {
                new Traveler("Anaïs", "Berlin", "Berlin", "Berlin", "Berlin"),
                new Traveler("Simon", "Hanoi", "Seoul", "Hanoi"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(1, result["Anaïs"]);
            Assert.AreEqual(2, result["Simon"]);
        }
    }
}
