using ExoMai2;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class TravelerHelperTests
    {
        [Fact]
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
            Assert.NotNull(result);
            Assert.Equal(travelers.Count, result.Count);
            Assert.Equal(1, result["Sébastien"]);
            Assert.Equal(3, result["Clémence"]);
            Assert.Equal(2, result["Antoine"]);
        }

        [Fact]
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
            Assert.NotNull(result);
            Assert.Equal(travelers.Count, result.Count);
            Assert.Equal(0, result["Thomas"]);
            Assert.Equal(2, result["Stéphanie"]);
        }

        [Fact]
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
            Assert.NotNull(result);
            Assert.Equal(travelers.Count, result.Count);
            Assert.Equal(3, result["Charlotte"]);
            Assert.Equal(2, result["James"]);
        }

        [Fact]
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
            Assert.NotNull(result);
            Assert.Equal(travelers.Count, result.Count);
            Assert.Equal(1, result["Anaïs"]);
            Assert.Equal(2, result["Simon"]);
        }
    }
}
