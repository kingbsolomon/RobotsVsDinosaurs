using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Robot
    {

        //member variables
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon robotWeapon;

        //Constructor
        public Robot(string robotName, int robotHealth, int robotPowerLevel, Weapon robotWeapon)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = robotWeapon;
        }

        //Methods
        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.dinosaurHealth -= robotWeapon.weaponAttackPower;
        }

        public void RobotPowerLoss(Robot robot)
        {
            robot.robotPowerLevel -= 10;
        }

    }
}
