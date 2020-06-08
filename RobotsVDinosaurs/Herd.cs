using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Herd
    {
        int dinosaurOneHealth;
        int dinosaurTwoHealth;
        int dinosaurThreeHealth;
        int dinosaurEnergyLevel;
        int dinosaurOneAttack;
        int dinosaurTwoAttack;
        int dinosaurThreeAttack;
        public List<Dinosaur> dinoList;
        
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

        void createHerd()
        {
            dinoList = new List<Dinosaur>();

            Dinosaur littleFoot = new Dinosaur("Littlefoot", dinosaurOneHealth, dinosaurEnergyLevel, dinosaurOneAttack);
            Dinosaur yoshi = new Dinosaur("Yoshi", dinosaurTwoHealth, dinosaurEnergyLevel, dinosaurTwoAttack);
            Dinosaur godzilla = new Dinosaur("Godzilla", dinosaurThreeHealth, dinosaurEnergyLevel, dinosaurThreeAttack);

            dinoList.Add(littleFoot);
            dinoList.Add(yoshi);
            dinoList.Add(godzilla);


        }

        public Herd()
        {
            setDinosaurAttributes();
            createHerd();
            
        }

    }
}
