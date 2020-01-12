using ExoMai4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class DictionaryOfListTest
    {
        public IDictionaryOfList<TKey, TItem> CreateDictionaryOfList<TKey, TItem>()
        {
            // Create your dictionary of list here. Example:
            //return new DictionaryOfList<TKey, TItem>();
            throw new NotImplementedException("Your forgot to create your dictionary of list");
        }

        [TestMethod]
        public void ItemCount_WithItems()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            Assert.AreEqual(3, dictionary.ItemCount);
        }

        [TestMethod]
        public void ItemCount_Empty()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            Assert.AreEqual(0, dictionary.ItemCount);
        }

        [TestMethod]
        public void IsEmpty_False()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            Assert.IsFalse(dictionary.IsEmpty);
        }

        [TestMethod]
        public void IsEmpty_True()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            Assert.IsTrue(dictionary.IsEmpty);
        }

        [TestMethod]
        public void Get_WithIndexer()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var fruits = dictionary["FRUIT"];
            Assert.AreEqual(2, fruits.Count());
            Assert.IsTrue(fruits.Contains("pomme"));
            Assert.IsTrue(fruits.Contains("orange"));

            var legumes = dictionary["LEGUME"];
            Assert.AreEqual(1, legumes.Count());
            Assert.IsTrue(legumes.Contains("haricot"));
        }

        [TestMethod]
        public void GetItemsFromKeys()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var fruits = dictionary.GetItemsFromKey("FRUIT");
            Assert.AreEqual(2, fruits.Count());
            Assert.IsTrue(fruits.Contains("pomme"));
            Assert.IsTrue(fruits.Contains("orange"));

            var legumes = dictionary.GetItemsFromKey("LEGUME");
            Assert.AreEqual(1, legumes.Count());
            Assert.IsTrue(legumes.Contains("haricot"));
        }

        [TestMethod]
        public void GetItemsFromKeys_Empty()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            var fruits = dictionary.GetItemsFromKey("FRUIT");
            Assert.IsFalse(fruits.Any());
        }

        [TestMethod]
        public void RemoveOneItem_1()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            dictionary.Remove("FRUIT", "pomme");

            var fruits = dictionary["FRUIT"];
            Assert.AreEqual(1, fruits.Count());
            Assert.IsTrue(fruits.Contains("orange"));

            var legumes = dictionary["LEGUME"];
            Assert.AreEqual(1, legumes.Count());
            Assert.IsTrue(legumes.Contains("haricot"));
        }

        [TestMethod]
        public void RemoveOneItem_2()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            dictionary.Remove("LEGUME", "haricot");

            var fruits = dictionary["FRUIT"];
            Assert.AreEqual(2, fruits.Count());
            Assert.IsTrue(fruits.Contains("pomme"));
            Assert.IsTrue(fruits.Contains("orange"));

            var legumes = dictionary.GetItemsFromKey("LEGUME");
            Assert.IsFalse(legumes.Any());
        }

        [TestMethod]
        public void Set_WithIndexer()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");

            var fruits = new List<string>() { "framboise", "banane" };
            dictionary["FRUIT"] = fruits;

            var fruitResult = dictionary["FRUIT"];
            Assert.AreEqual(2, fruitResult.Count());
            Assert.IsTrue(fruitResult.Contains("framboise"));
            Assert.IsTrue(fruitResult.Contains("banane"));
        }

        [TestMethod]
        public void AddRange()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            var fruits = new List<string>() { "framboise", "banane" };
            dictionary.AddRange("FRUIT", fruits);

            var fruitResult = dictionary["FRUIT"];
            Assert.AreEqual(2, fruitResult.Count());
            Assert.IsTrue(fruitResult.Contains("framboise"));
            Assert.IsTrue(fruitResult.Contains("banane"));
        }

        [TestMethod]
        public void GetAllItems()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var result = dictionary.GetAllItems();
            Assert.AreEqual(3, result.Count());
            Assert.IsTrue(result.Contains("pomme"));
            Assert.IsTrue(result.Contains("orange"));
            Assert.IsTrue(result.Contains("haricot"));
        }

        [TestMethod]
        public void RemoveKey()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            dictionary.Remove("FRUIT");

            var result = dictionary.GetAllItems();
            Assert.AreEqual(1, result.Count());
            Assert.IsTrue(result.Contains("haricot"));
        }
    }
}
