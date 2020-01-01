using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ExoLibXml
{
    public class AnimalXmlSerializer
    {
        private XmlSerializer _xmlSerializer;
        private string _filePath;

        public AnimalXmlSerializer(string filePath)
        {
            _filePath = filePath;
            _xmlSerializer = new XmlSerializer(typeof(List<AnimalXmlEntry>));
        }

        public void Append(AnimalXmlEntry animalEntry)
        {
            List<AnimalXmlEntry> existingAnimals = ReadAll().ToList();
            existingAnimals.Add(animalEntry);
            OverwriteAll(existingAnimals);
        }

        public void OverwriteAll(List<AnimalXmlEntry> animalEntryList)
        {
            TextWriter writer = new StreamWriter(_filePath);
            _xmlSerializer.Serialize(writer, animalEntryList);
            writer.Close();
        }

        public IEnumerable<AnimalXmlEntry> ReadAll()
        {
            try
            {
                FileStream fs = new FileStream(_filePath, FileMode.Open);
                var res = (List<AnimalXmlEntry>)_xmlSerializer.Deserialize(fs);
                fs.Close();
                return res;
            }
            catch (FileNotFoundException)
            {
                return Enumerable.Empty<AnimalXmlEntry>();
            }
        }
    }
}
