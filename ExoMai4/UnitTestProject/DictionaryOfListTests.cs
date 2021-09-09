using ExoMai4;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTestProject
{
    public class DictionaryOfListTests
    {
        public IDictionaryOfList<TKey, TItem> CreateDictionaryOfList<TKey, TItem>()
        {
            // Create your dictionary of list here. Example:
            //return new DictionaryOfList<TKey, TItem>();
            throw new NotImplementedException("Your forgot to create your dictionary of list");
        }

        [Fact]
        public void ItemCount_WithItems()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            Assert.Equal(3, dictionary.ItemCount);
        }

        [Fact]
        public void ItemCount_Empty()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            Assert.Equal(0, dictionary.ItemCount);
        }

        [Fact]
        public void IsEmpty_False()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            Assert.False(dictionary.IsEmpty);
        }

        [Fact]
        public void IsEmpty_True()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            Assert.True(dictionary.IsEmpty);
        }

        [Fact]
        public void Get_WithIndexer()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var fruits = dictionary["FRUIT"];
            Assert.Equal(2, fruits.Count());
            Assert.Contains("pomme", fruits);
            Assert.Contains("orange", fruits);

            var legumes = dictionary["LEGUME"];
            Assert.Single(legumes);
            Assert.Contains("haricot", legumes);
        }

        [Fact]
        public void GetItemsFromKeys()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var fruits = dictionary.GetItemsFromKey("FRUIT");
            Assert.Equal(2, fruits.Count());
            Assert.Contains("pomme", fruits);
            Assert.Contains("orange", fruits);

            var legumes = dictionary.GetItemsFromKey("LEGUME");
            Assert.Single(legumes);
            Assert.Contains("haricot", legumes);
        }

        [Fact]
        public void GetItemsFromKeys_Empty()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            var fruits = dictionary.GetItemsFromKey("FRUIT");
            Assert.Empty(fruits);
        }

        [Fact]
        public void RemoveOneItem_1()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            dictionary.Remove("FRUIT", "pomme");

            var fruits = dictionary["FRUIT"];
            Assert.Single(fruits);
            Assert.Contains("orange", fruits);

            var legumes = dictionary["LEGUME"];
            Assert.Single(legumes);
            Assert.Contains("haricot", legumes);
        }

        [Fact]
        public void RemoveOneItem_2()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");
            dictionary.Remove("LEGUME", "haricot");

            var fruits = dictionary["FRUIT"];
            Assert.Equal(2, fruits.Count());
            Assert.Contains("pomme", fruits);
            Assert.Contains("orange", fruits);

            var legumes = dictionary.GetItemsFromKey("LEGUME");
            Assert.Empty(legumes);
        }

        [Fact]
        public void Set_WithIndexer()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");

            var fruits = new List<string>() { "framboise", "banane" };
            dictionary["FRUIT"] = fruits;

            var fruitResult = dictionary["FRUIT"];
            Assert.Equal(2, fruitResult.Count());
            Assert.Contains("framboise", fruitResult);
            Assert.Contains("banane", fruitResult);
        }

        [Fact]
        public void AddRange()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            var fruits = new List<string>() { "framboise", "banane" };
            dictionary.AddRange("FRUIT", fruits);

            var fruitResult = dictionary["FRUIT"];
            Assert.Equal(2, fruitResult.Count());
            Assert.Contains("framboise", fruitResult);
            Assert.Contains("banane", fruitResult);
        }

        [Fact]
        public void GetAllItems()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            var result = dictionary.GetAllItems();
            Assert.Equal(3, result.Count());
            Assert.Contains("pomme", result);
            Assert.Contains("orange", result);
            Assert.Contains("haricot", result);
        }

        [Fact]
        public void RemoveKey()
        {
            var dictionary = CreateDictionaryOfList<string, string>();
            dictionary.Add("FRUIT", "pomme");
            dictionary.Add("FRUIT", "orange");
            dictionary.Add("LEGUME", "haricot");

            dictionary.Remove("FRUIT");

            var result = dictionary.GetAllItems();
            Assert.Single(result);
            Assert.Contains("haricot", result);
        }
    }
}
