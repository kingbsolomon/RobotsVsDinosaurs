using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RobotsVDinosaurs
{

    class Fleet
    {

        public int robotOneHealth;
        public int robotTwoHealth;
        public int robotThreeHealth;
        public int robotPowerLevel;
        public int robotOneAttack;
        public int robotTwoAttack;
        public int robotThreeAttack;
        public string WeaponName;
        public void setRobotAttributes()
        {
            Random rnd = new Random();

            robotOneHealth = rnd.Next(30, 50);
            robotTwoHealth = rnd.Next(50, 70);
            robotThreeHealth = rnd.Next(80, 100);

            robotOneAttack = rnd.Next(5, 10);
            robotTwoAttack = rnd.Next(10, 15);
            robotThreeAttack = rnd.Next(15, 25);


            robotPowerLevel = 100;



        }

        public Fleet()
        {
            Weapon wpn1 = new Weapon();
            Robot r2d2 = new Robot("R2D2",robotOneHealth,robotPowerLevel,wpn1);

            Weapon wpn2 = new Weapon();
            Robot bender = new Robot("Bender", robotTwoHealth, robotPowerLevel, wpn2);

            Weapon wpn3 = new Weapon();
            Robot optimusPrime = new Robot("Optimus Prime", robotThreeHealth, robotPowerLevel, wpn3);

        }





    }
}
