using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Herd
    {
        public int dinosaurOneHealth;
        public int dinosaurTwoHealth;
        public int dinosaurThreeHealth;
        public int dinosaurEnergyLevel;
        public int dinosaurOneAttack;
        public int dinosaurTwoAttack;
        public int dinosaurThreeAttack;
        
        public void setDinosaurAttributes()
        {
            Random rnd = new Random();

            dinosaurOneHealth = rnd.Next(30, 50);
            dinosaurOneAttack = rnd.Next(5, 10);

            dinosaurTwoHealth = rnd.Next(50, 70);
            dinosaurTwoAttack = rnd.Next(10, 15);

            dinosaurThreeHealth = rnd.Next(80, 100);
            dinosaurThreeAttack = rnd.Next(15, 25);

            dinosaurEnergyLevel = 100;

        }

        public Herd()
        {
            Dinosaur litteFoot = new Dinosaur("Littlefoot", dinosaurOneHealth, dinosaurEnergyLevel, dinosaurOneAttack);
            Dinosaur yoshi = new Dinosaur("Yoshi", dinosaurTwoHealth, dinosaurEnergyLevel, dinosaurTwoAttack);
            Dinosaur godzilla = new Dinosaur("Godzilla", dinosaurThreeHealth, dinosaurEnergyLevel, dinosaurThreeAttack);

        }

    }
}
