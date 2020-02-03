using ExoMai3;
using ExoMai3.Food;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTasting
{
    [TestClass]
    public class EnchantedFoodUnitTasting
    {
        IEnchantedFood GetPeanut() => new Peanut();
        IEnchantedFood GetCookie() => throw new NotImplementedException("You forgot to create a cookie here!");
        IEnchantedFood GetSuperCookie() => throw new NotImplementedException("You forgot to create a super cookie here!");
        IEnchantedFood GetApple() => throw new NotImplementedException("You forgot to create an apple here!");
        IEnchantedFood GetRaspberry() => throw new NotImplementedException("You forgot to create a raspberry here!");
        IEnchantedFood GetAppleRaspberryPie() => throw new NotImplementedException("You forgot to create an apple-raspberry pie here!");
        IEnchantedFood GetCandy() => throw new NotImplementedException("You forgot to create a candy here!");
        IEnchantedFood GetCroissant() => throw new NotImplementedException("You forgot to create a croissant here!");
        IEnchantedFood GetChocolate() => throw new NotImplementedException("You forgot to create chocolate here!");


        [TestMethod]
        public void TastePeanut()
        {
            Adventurer adventurer = new Adventurer("Victor", 5, 27, 21);
            IEnchantedFood peanut = GetPeanut();
            adventurer.Eat(peanut);
            AssertAdventurer(adventurer, 5, 27, 22);
        }

        [TestMethod]
        public void TasteCookie()
        {
            Adventurer adventurer = new Adventurer("Roger", 20, 8, 14);
            IEnchantedFood cookie = GetCookie();
            adventurer.Eat(cookie);
            AssertAdventurer(adventurer, 20, 7, 18);
        }

        [TestMethod]
        public void TasteSuperCookie()
        {
            Adventurer adventurer = new Adventurer("Charlotte", 12, 15, 20);
            IEnchantedFood superCookie = GetSuperCookie();
            adventurer.Eat(superCookie);
            AssertAdventurer(adventurer, 62, 14, 24);
        }

        [TestMethod]
        public void TasteApple()
        {
            Adventurer adventurer = new Adventurer("Sophie", 17, 32, 11);
            IEnchantedFood apple = GetApple();
            adventurer.Eat(apple);
            AssertAdventurer(adventurer, 22, 34, 11);
        }

        [TestMethod]
        public void TasteRaspberry()
        {
            Adventurer adventurer = new Adventurer("Simon", 10, 10, 8);
            IEnchantedFood raspberry = GetRaspberry();
            adventurer.Eat(raspberry);
            AssertAdventurer(adventurer, 10, 12, 12);
        }

        [TestMethod]
        public void TasteAppleRaspberryPie()
        {
            Adventurer adventurer = new Adventurer("Louise", 20, 41, 37);
            IEnchantedFood pie = GetAppleRaspberryPie();
            adventurer.Eat(pie);
            AssertAdventurer(adventurer, 25, 45, 51);
        }

        [TestMethod]
        public void TasteCandy_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 11, 20, 40);
            IEnchantedFood candy = GetCandy();
            adventurer.Eat(candy);
            AssertAdventurer(adventurer, 11, 20, 40);
        }

        [TestMethod]
        public void TasteCandy_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 9, 20, 40);
            IEnchantedFood candy = GetCandy();
            adventurer.Eat(candy);
            AssertAdventurer(adventurer, 14, 20, 40);
        }

        [TestMethod]
        public void TasteCroissant_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 11, 20, 40);
            IEnchantedFood croissant = GetCroissant();
            adventurer.Eat(croissant);
            AssertAdventurer(adventurer, 11, 20, 40);
        }

        [TestMethod]
        public void TasteCroissant_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 9, 20, 40);
            IEnchantedFood croissant = GetCroissant();
            adventurer.Eat(croissant);
            AssertAdventurer(adventurer, 14, 20, 40);
        }

        [TestMethod]
        public void TasteChocolate_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Julie", 41, 20, 21);
            IEnchantedFood chocolate = GetChocolate();
            adventurer.Eat(chocolate);
            AssertAdventurer(adventurer, 41, 20, 41);
        }

        [TestMethod]
        public void TasteChocolate_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Julie", 5, 20, 40);
            IEnchantedFood chocolate = GetChocolate();
            adventurer.Eat(chocolate);
            AssertAdventurer(adventurer, 10, 20, 60);
        }


        #region Helper method

        private void AssertAdventurer(Adventurer adv, int strength, int wisdom, int happiness)
        {
            Assert.AreEqual(strength, adv.Strength, $"Expected strength : <{strength}>. Actual strength : <{adv.Strength}>.");
            Assert.AreEqual(wisdom, adv.Wisdom, $"Expected wisdom : <{wisdom}>. Actual wisdom : <{adv.Wisdom}>.");
            Assert.AreEqual(happiness, adv.Happiness, $"Expected happiness : <{happiness}>. Actual happiness : <{adv.Happiness}>.");
        }

        #endregion
    }
}
