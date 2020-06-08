using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RobotsVDinosaurs
{

    class Fleet
    {

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
        public void setRobotAttributes()
        {
            Random rnd = new Random();

            robotOneHealth = rnd.Next(30, 50);
            robotTwoHealth = rnd.Next(50, 70);
            robotThreeHealth = rnd.Next(80, 100);
            
            robotPowerLevel = 100;
        }

        public void setRobotWeapon()
        {
            Random rnd = new Random();
            List<string> weapon = new List<string>{
                "Particle Beam Cannon","Portal Ripper","Atomic Annie","Queller of the Sky",
                "Corroded Six Shooter","Klingon Disrupter","Steampunk Blaster" };

            int weaponOneInt = rnd.Next(weapon.Count);
            weaponName1 = weapon[weaponOneInt];
            robotOneAttack = rnd.Next(5, 10);

            int weaponTwoInt = rnd.Next(weapon.Count);
            weaponName2 = weapon[weaponTwoInt];
            robotTwoAttack = rnd.Next(10,15);

            int weaponThreeInt = rnd.Next(weapon.Count);
            weaponName3 = weapon[weaponThreeInt];
            robotThreeAttack = rnd.Next(15, 25);

        }

        public void createFleet()
        {
            Weapon wpn1 = new Weapon(weaponName1, robotOneAttack);
            Robot r2d2 = new Robot("R2D2", robotOneHealth, robotPowerLevel, wpn1);

            Weapon wpn2 = new Weapon(weaponName2, robotTwoAttack);
            Robot bender = new Robot("Bender", robotTwoHealth, robotPowerLevel, wpn2);

            Weapon wpn3 = new Weapon(weaponName3, robotThreeAttack);
            Robot optimusPrime = new Robot("Optimus Prime", robotThreeHealth, robotPowerLevel, wpn3);

            robotList = new List<Robot>();
            robotList.Add(r2d2);
            robotList.Add(bender);
            robotList.Add(optimusPrime);
        }

        public Fleet()
        {
            setRobotAttributes();
            setRobotWeapon();
            createFleet();

        }





    }
}
