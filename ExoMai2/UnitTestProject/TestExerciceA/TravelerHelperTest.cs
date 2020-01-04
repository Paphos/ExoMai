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
                new Traveler("S�bastien", "Paris"),
                new Traveler("Cl�mence", "London", "Mumbai", "New York"),
                new Traveler("Antoine", "New York", "Tokyo"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(1, result["S�bastien"]);
            Assert.AreEqual(3, result["Cl�mence"]);
            Assert.AreEqual(2, result["Antoine"]);
        }

        [TestMethod]
        public void GetNumberOfCountryVisitedByTravellers_TravellerCanVisitZeroCountry()
        {
            // Arrange
            List<Traveler> travelers = new List<Traveler>()
            {
                new Traveler("Thomas"),
                new Traveler("St�phanie", "Geneva", "Stockholm"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(0, result["Thomas"]);
            Assert.AreEqual(2, result["St�phanie"]);
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
                new Traveler("Ana�s", "Berlin", "Berlin", "Berlin", "Berlin"),
                new Traveler("Simon", "Hanoi", "Seoul", "Hanoi"),
            };

            // Act
            Dictionary<string, int> result = TravelerHelper.GetNumberOfCountryVisitedByTravellers(travelers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(travelers.Count, result.Count);
            Assert.AreEqual(1, result["Ana�s"]);
            Assert.AreEqual(2, result["Simon"]);
        }
    }
}
