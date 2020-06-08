using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string dinosaurType;
        public int dinosaurHealth;
        public int dinosaurEnergy;
        public int dinosaurAttackPower;

        //Constructor
        public Dinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergy, int dinosaurAttackPower)
        {
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergy = dinosaurEnergy;
            this.dinosaurAttackPower = dinosaurAttackPower;
        }

    }
}
