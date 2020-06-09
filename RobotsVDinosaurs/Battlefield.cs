using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RobotsVDinosaurs
{
    class Battlefield
    {
        public Fleet robotTeam = new Fleet();
        public Herd dinoTeam = new Herd();
        int i = 0;

      public void LetsBattle()
        {

            Robot robot = new Robot(robotTeam.robotList[0].robotName, robotTeam.robotList[0].robotHealth,
                        robotTeam.robotList[0].robotPowerLevel, robotTeam.robotList[0].robotWeapon);

            Dinosaur dino = new Dinosaur(dinoTeam.dinoList[0].dinosaurType, dinoTeam.dinoList[0].dinosaurHealth,
                dinoTeam.dinoList[0].dinosaurEnergy, dinoTeam.dinoList[0].dinosaurAttackPower);

          //  PrintAttributes();

            while ((robotTeam.robotList.Count > 0) && (dinoTeam.dinoList.Count > 0))
            {
                Console.Clear();

                while ((robotTeam.robotList[0].robotHealth > 0) && (dinoTeam.dinoList[0].dinosaurHealth > 0))
                {
                    robot.RobotAttack(dinoTeam.dinoList[0]);
                    dino.DinoAttack(robotTeam.robotList[0]);

                    PrintAttributes();
                    CheckBattleWinner();
                    Console.Write("Press Enter to Attack: \n");
                    robot.RobotPowerLoss(robotTeam.robotList[0]);
                    dino.DinoEnergyLoss(dinoTeam.dinoList[0]);
                    Console.ReadLine();

                }
            }
            CheckGameWinner();
        }
        
        public void PrintAttributes()
        {
            Console.WriteLine("Battle {0}: Robot {1} \t\t\t vs \t\t\t Dinosaur {2}", i + 1, robotTeam.robotList[0].robotName,
                    dinoTeam.dinoList[0].dinosaurType);

            Console.WriteLine("Robot Health: {1} \t\t\t vs \t\t\t Dinosaur Health: {2}", i + 1, robotTeam.robotList[0].robotHealth,
                    dinoTeam.dinoList[0].dinosaurHealth);

            Console.WriteLine("Robot Power Level: {1} \t\t\t vs \t\t\t Dinosaur Energy: {2}", i + 1, robotTeam.robotList[0].robotPowerLevel,
                    dinoTeam.dinoList[0].dinosaurEnergy);

            Console.WriteLine("Robot Attack Power {1} \t\t\t vs \t\t\t Dinosaur Attack Power {2}\n", i + 1, robotTeam.robotList[0].robotWeapon.weaponAttackPower,
                        dinoTeam.dinoList[0].dinosaurAttackPower);
        }

        public void CheckBattleWinner()
        {
            if (robotTeam.robotList[0].robotHealth <= 0 || dinoTeam.dinoList[0].dinosaurHealth <= 0)
            {

                if (robotTeam.robotList[0].robotHealth > dinoTeam.dinoList[0].dinosaurHealth)
                {
                    Console.WriteLine("Robot {0} Defeated Dinosaur {1}\n", robotTeam.robotList[0].robotName, dinoTeam.dinoList[0].dinosaurType);
                    dinoTeam.dinoList.RemoveAt(0);
                    i++;
                    PrintAttributes();
                }
                else if (robotTeam.robotList[0].robotHealth < dinoTeam.dinoList[0].dinosaurHealth)
                {
                    Console.WriteLine("Dinosaur {0} Defeated Robot {1}\n", dinoTeam.dinoList[0].dinosaurType, robotTeam.robotList[0].robotName);
                    robotTeam.robotList.RemoveAt(0);
                    i++;
                    PrintAttributes();
                }
            }
        }

        public void CheckGameWinner()
        {
            if(robotTeam.robotList.Count > dinoTeam.dinoList.Count)
            {
                Console.WriteLine("ROBOTS WIN!!!!");
            }
            else
            {
                Console.WriteLine("DINOSAURS WIN");
            }
        }
           
    }
}
