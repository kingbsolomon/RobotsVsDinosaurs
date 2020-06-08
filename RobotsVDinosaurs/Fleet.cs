using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RobotsVDinosaurs
{

    class Fleet
    {
        //member variables
        int robotOneHealth;
        int robotTwoHealth;
        int robotThreeHealth;
        int robotPowerLevel;
        int robotOneAttack;
        int robotTwoAttack;
        int robotThreeAttack;
        string weaponName1;
        string weaponName2;
        string weaponName3;
        public List<Robot> robotList;
        Random rnd = new Random();

        //Methods
        public void SetRobotAttributes()
        {
            robotOneHealth = rnd.Next(30, 40);
            robotTwoHealth = rnd.Next(50, 70);
            robotThreeHealth = rnd.Next(80, 100);
            robotPowerLevel = 100;
        }

        public void SetRobotsWeapon()
        {
            List<string> weapon = new List<string>{
                "Particle Beam Cannon","Portal Ripper","Atomic Annie","Queller of the Sky",
                "Corroded Six Shooter","Klingon Disrupter","Steampunk Blaster" };

            weaponName1 = weapon[rnd.Next(weapon.Count)];
            robotOneAttack = rnd.Next(5, 10);

            weaponName2 = weapon[rnd.Next(weapon.Count)];
            robotTwoAttack = rnd.Next(10, 15);

            weaponName3 = weapon[rnd.Next(weapon.Count)];
            robotThreeAttack = rnd.Next(15, 25);
        }

        public void CreateFleet()
        {
            robotList = new List<Robot>() 
            { 
                new Robot("R2D2", robotOneHealth, robotPowerLevel, new Weapon(weaponName1, robotOneAttack)),
                new Robot("Bender", robotTwoHealth, robotPowerLevel, new Weapon(weaponName2, robotTwoAttack)),
                new Robot("Optimus Prime", robotThreeHealth, robotPowerLevel, new Weapon(weaponName3, robotThreeAttack))
            };
        }

        //Constructor
        public Fleet()
        {
            SetRobotAttributes();
            SetRobotsWeapon();
            CreateFleet();
        }
    }
}
