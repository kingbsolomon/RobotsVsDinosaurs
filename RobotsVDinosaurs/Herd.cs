using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Herd
    {
        //member variables
        int dinosaurOneHealth;
        int dinosaurTwoHealth;
        int dinosaurThreeHealth;
        int dinosaurEnergyLevel;
        int dinosaurOneAttack;
        int dinosaurTwoAttack;
        int dinosaurThreeAttack;
        public List<Dinosaur> dinoList;
        
        //Methods
        public void SetDinosaurAttributes()
        {
            Random rnd = new Random();

            dinosaurOneHealth = rnd.Next(30, 40);
            dinosaurOneAttack = rnd.Next(5, 10);

            dinosaurTwoHealth = rnd.Next(50, 70);
            dinosaurTwoAttack = rnd.Next(10, 15);

            dinosaurThreeHealth = rnd.Next(80, 100);
            dinosaurThreeAttack = rnd.Next(15, 25);

            dinosaurEnergyLevel = 100;
        }

        void CreateHerd()
        {
            dinoList = new List<Dinosaur>()
            {
            new Dinosaur("Littlefoot", dinosaurOneHealth, dinosaurEnergyLevel, dinosaurOneAttack),
            new Dinosaur("Yoshi", dinosaurTwoHealth, dinosaurEnergyLevel, dinosaurTwoAttack),
            new Dinosaur("Godzilla", dinosaurThreeHealth, dinosaurEnergyLevel, dinosaurThreeAttack)
            };
        }
        
        //Constructor
        public Herd()
        {
            SetDinosaurAttributes();
            CreateHerd();
        }
    }
}
