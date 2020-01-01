using ExoMai1.Models;
using System.Collections.Generic;

namespace ExoMai1.Services
{
    public interface IZooService
    {
        void Add(AnimalModel animal);
        IEnumerable<AnimalModel> GetAll();
    }
}
