using ExoMai2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class VerySmallCityTest
    {
        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
        }

        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
        }

        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerRoger.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerStephanie.VisitedCities.Contains("Berlin"));
        }

        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerRoger.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerStephanie.VisitedCities.Contains("Berlin"));
        }

        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerRoger.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerStephanie.VisitedCities.Contains("Berlin"));
        }

        [TestMethod]
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
            Assert.IsTrue(travelerSimon.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerCharlotte.VisitedCities.Contains("Berlin"));
            Assert.IsFalse(travelerRoger.VisitedCities.Contains("Berlin"));
            Assert.IsTrue(travelerStephanie.VisitedCities.Contains("Berlin"));
        }
    }
}
