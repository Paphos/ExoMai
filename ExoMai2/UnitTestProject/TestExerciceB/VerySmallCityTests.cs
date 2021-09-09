using ExoMai2;
using Xunit;

namespace UnitTestProject
{
    public class VerySmallCityTests
    {
        [Fact]
        public void HappyPath()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 100);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");

            // Act
            city.Enter(travelerSimon);
            city.Enter(travelerCharlotte);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
        }

        [Fact]
        public void TravelersEnterThenLeaveOneByOne()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 1);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");

            // Act
            city.Enter(travelerSimon);
            city.Leave(travelerSimon);
            city.Enter(travelerCharlotte);
            city.Leave(travelerCharlotte);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
        }

        [Fact]
        public void TooManyTravelersTryEnteringTheCity()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 2);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");
            Traveler travelerRoger = new Traveler("Roger");
            Traveler travelerStephanie = new Traveler("Stéphanie");

            // Act
            city.Enter(travelerSimon);
            city.Enter(travelerCharlotte);
            city.Enter(travelerRoger);
            city.Enter(travelerStephanie);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerRoger.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerStephanie.VisitedCities);
        }

        [Fact]
        public void TravelerLeavesAfterVisitingAllowingWaitingTravelerToEnter()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 2);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");
            Traveler travelerRoger = new Traveler("Roger");
            Traveler travelerStephanie = new Traveler("Stéphanie");

            // Act
            city.Enter(travelerSimon);
            city.Enter(travelerCharlotte);
            city.Enter(travelerRoger);
            city.Enter(travelerStephanie);

            city.Leave(travelerCharlotte);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
            Assert.Contains("Berlin", travelerRoger.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerStephanie.VisitedCities);
        }

        [Fact]
        public void TravelerLeavesBeforeVisiting_1()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 2);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");
            Traveler travelerRoger = new Traveler("Roger");
            Traveler travelerStephanie = new Traveler("Stéphanie");

            // Act
            city.Enter(travelerSimon);
            city.Enter(travelerCharlotte);
            city.Enter(travelerRoger);
            city.Enter(travelerStephanie);

            city.Leave(travelerRoger);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerRoger.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerStephanie.VisitedCities);
        }

        [Fact]
        public void TravelerLeavesBeforeVisiting_2()
        {
            // Arrange
            VerySmallCity city = new VerySmallCity("Berlin", 2);
            Traveler travelerSimon = new Traveler("Simon");
            Traveler travelerCharlotte = new Traveler("Charlotte");
            Traveler travelerRoger = new Traveler("Roger");
            Traveler travelerStephanie = new Traveler("Stéphanie");

            // Act
            city.Enter(travelerSimon);
            city.Enter(travelerCharlotte);
            city.Enter(travelerRoger);
            city.Enter(travelerStephanie);

            city.Leave(travelerRoger);
            city.Leave(travelerCharlotte);

            // Assert
            Assert.Contains("Berlin", travelerSimon.VisitedCities);
            Assert.Contains("Berlin", travelerCharlotte.VisitedCities);
            Assert.DoesNotContain("Berlin", travelerRoger.VisitedCities);
            Assert.Contains("Berlin", travelerStephanie.VisitedCities);
        }
    }
}
