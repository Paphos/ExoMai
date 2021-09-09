using ExoMai4;
using Xunit;

namespace UnitTestProject
{
    public class TwoKeyDictionaryTests
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

        [Fact]
        public void TestExample()
        {
            var twoKeyDictionary = CreateTwoKeyDictionary<FoodEnum, string, string>();
            twoKeyDictionary.Add(FoodEnum.Fruit, "red", "strawberry");
            twoKeyDictionary.Add(FoodEnum.Fruit, "yellow", "lemon");
            twoKeyDictionary.Add(FoodEnum.Meat, "red", "beef");
            Assert.Equal("strawberry", twoKeyDictionary[FoodEnum.Fruit, "red"]);
            Assert.Equal("lemon", twoKeyDictionary[FoodEnum.Fruit, "yellow"]);
            Assert.Equal("beef", twoKeyDictionary[FoodEnum.Meat, "red"]);
        }
    }
}
