namespace ExoMai5
{
    public class City
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Population { get; set; }

        public City(string name, string departement, int population)
        {
            this.Name = name;
            this.Department = departement;
            this.Population = population;
        }

        public override string ToString()
        {
            return $"City:{this.Name}";
        }
    }
}
