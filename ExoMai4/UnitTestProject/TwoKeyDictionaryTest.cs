using ExoMai4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{
    [TestClass]
    public class TwoKeyDictionaryTest
    {
        public ITwoKeyDictionary<TKey1, TKey2, TValue> CreateTwoKeyDictionary<TKey1, TKey2, TValue>()
        {
            return new TwoKeyDictionary<TKey1, TKey2, TValue>();
        }

        public enum FoodEnum
        {
            Fruit,
            Vegetable,
            Meat
        };

        [TestMethod]
        public void TestExample()
        {
            var twoKeyDictionary = CreateTwoKeyDictionary<FoodEnum, string, string>();
            twoKeyDictionary.Add(FoodEnum.Fruit, "red", "strawberry");
            twoKeyDictionary.Add(FoodEnum.Fruit, "yellow", "lemon");
            twoKeyDictionary.Add(FoodEnum.Meat, "red", "beef");
            Assert.AreEqual("strawberry", twoKeyDictionary[FoodEnum.Fruit, "red"]);
            Assert.AreEqual("lemon", twoKeyDictionary[FoodEnum.Fruit, "yellow"]);
            Assert.AreEqual("beef", twoKeyDictionary[FoodEnum.Meat, "red"]);
        }
    }
}
