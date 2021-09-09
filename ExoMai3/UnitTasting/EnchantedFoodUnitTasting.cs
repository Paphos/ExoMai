using ExoMai3;
using ExoMai3.Food;
using System;
using Xunit;

namespace UnitTasting
{
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
        IEnchantedFood GetChocolateCake() => throw new NotImplementedException("You forgot to create the chocolate cake here!");
        IEnchantedFood GetLemonPie() => throw new NotImplementedException("You forgot to create the lemon pie here!");


        [Fact]
        public void TastePeanut()
        {
            Adventurer adventurer = new Adventurer("Victor", 5, 27, 21);
            IEnchantedFood peanut = GetPeanut();
            adventurer.Eat(peanut);
            AssertAdventurer(adventurer, 5, 27, 22);
        }

        [Fact]
        public void TasteCookie()
        {
            Adventurer adventurer = new Adventurer("Roger", 20, 8, 14);
            IEnchantedFood cookie = GetCookie();
            adventurer.Eat(cookie);
            AssertAdventurer(adventurer, 20, 7, 18);
        }

        [Fact]
        public void TasteSuperCookie()
        {
            Adventurer adventurer = new Adventurer("Charlotte", 12, 15, 20);
            IEnchantedFood superCookie = GetSuperCookie();
            adventurer.Eat(superCookie);
            AssertAdventurer(adventurer, 62, 14, 24);
        }

        [Fact]
        public void TasteApple()
        {
            Adventurer adventurer = new Adventurer("Sophie", 17, 32, 11);
            IEnchantedFood apple = GetApple();
            adventurer.Eat(apple);
            AssertAdventurer(adventurer, 22, 34, 11);
        }

        [Fact]
        public void TasteRaspberry()
        {
            Adventurer adventurer = new Adventurer("Simon", 10, 10, 8);
            IEnchantedFood raspberry = GetRaspberry();
            adventurer.Eat(raspberry);
            AssertAdventurer(adventurer, 10, 12, 12);
        }

        [Fact]
        public void TasteAppleRaspberryPie()
        {
            Adventurer adventurer = new Adventurer("Louise", 20, 41, 37);
            IEnchantedFood pie = GetAppleRaspberryPie();
            adventurer.Eat(pie);
            AssertAdventurer(adventurer, 25, 45, 51);
        }

        [Fact]
        public void TasteCandy_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 11, 20, 40);
            IEnchantedFood candy = GetCandy();
            adventurer.Eat(candy);
            AssertAdventurer(adventurer, 11, 20, 40);
        }

        [Fact]
        public void TasteCandy_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 9, 20, 40);
            IEnchantedFood candy = GetCandy();
            adventurer.Eat(candy);
            AssertAdventurer(adventurer, 14, 20, 40);
        }

        [Fact]
        public void TasteCroissant_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 11, 20, 40);
            IEnchantedFood croissant = GetCroissant();
            adventurer.Eat(croissant);
            AssertAdventurer(adventurer, 11, 20, 40);
        }

        [Fact]
        public void TasteCroissant_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Sébastien", 9, 20, 40);
            IEnchantedFood croissant = GetCroissant();
            adventurer.Eat(croissant);
            AssertAdventurer(adventurer, 14, 20, 40);
        }

        [Fact]
        public void TasteChocolate_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Julie", 41, 20, 21);
            IEnchantedFood chocolateCake = GetChocolateCake();
            adventurer.Eat(chocolateCake);
            AssertAdventurer(adventurer, 41, 20, 71);
        }

        [Fact]
        public void TasteChocolate_NoEffect()
        {
            Adventurer adventurer = new Adventurer("Julie", 5, 20, 40);
            IEnchantedFood chocolateCake = GetChocolateCake();
            adventurer.Eat(chocolateCake);
            AssertAdventurer(adventurer, 10, 20, 90);
        }

        [Fact]
        public void TasteLemonPie_HasEffect()
        {
            Adventurer adventurer = new Adventurer("Charlotte", 41, 37, 54);
            IEnchantedFood lemonPie = GetLemonPie();
            adventurer.Eat(lemonPie);
            AssertAdventurer(adventurer, 67, 39, 54);
        }


        #region Helper method

        private void AssertAdventurer(Adventurer adv, int strength, int wisdom, int happiness)
        {
            Assert.Equal(strength, adv.Strength);
            Assert.Equal(wisdom, adv.Wisdom);
            Assert.Equal(happiness, adv.Happiness);
        }

        #endregion
    }
}
