using System;
using System.Collections.Generic;
using System.Text;

namespace ExoMai2
{
    public class VerySmallCity
    {
        private string _name;
        private int _numberOfTravelerAllowedAtTheSameTime;

        public VerySmallCity(string name, int numberOfTravelerAllowedAtTheSameTime)
        {
            _name = name;
            _numberOfTravelerAllowedAtTheSameTime = numberOfTravelerAllowedAtTheSameTime;
        }

        public void Enter(Traveler traveler)
        {
            // A compléter
            throw new NotImplementedException();
        }

        public void Leave(Traveler traveler)
        {
            // A compléter
            throw new NotImplementedException();
        }
    }
}
