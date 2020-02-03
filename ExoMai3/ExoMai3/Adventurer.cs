namespace ExoMai3
{
    public class Adventurer
    {
        public string Name { get; private set; }

        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Happiness { get; set; }

        public Adventurer(string name, int strength, int wisdom, int happiness)
        {
            this.Name = name;
            this.Strength = strength;
            this.Wisdom = wisdom;
            this.Happiness = happiness;
        }

        public void Eat(IEnchantedFood food)
        {
            food.ApplyEffect(this);
        }
    }
}
