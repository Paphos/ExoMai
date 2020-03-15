using System.Collections.Generic;
using System.IO;

namespace ExoMai5
{
    public class CityCsvDeserializer
    {
        private string _filepath;

        public CityCsvDeserializer(string filepath)
        {
            _filepath = filepath;
        }

        public IEnumerable<City> ReadCities()
        {
            List<City> cities = new List<City>();
            using (var reader = new StreamReader(_filepath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    //string num = values[0];
                    string department = GetString(values, 1);
                    string name = GetString(values, 2);
                    int population = GetInt(values, 3);

                    cities.Add(new City(name, department, population));
                }
            }
            return cities;
        }

        private string GetString(string[] fields, int fieldNumber)
        {
            if (fields.Length <= fieldNumber)
                throw new InvalidDataException($"Wrong CSV line. Expected 4 fields but got only {fields.Length}");

            return fields[fieldNumber];
        }

        private int GetInt(string[] fields, int fieldNumber)
        {
            string str = GetString(fields, fieldNumber);
            return int.Parse(str);
        }
    }
}
