namespace ExoMai3.Food
{
    public class Peanut : IEnchantedFood
    {
        public void ApplyEffect(Adventurer adventurer)
        {
            adventurer.Happiness += 1;
        }
    }
}
