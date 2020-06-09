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
        public string dinoAttack;

      public void LetsBattle()
        {
            dinoAttack = dinoTeam.dinoList[0].SelectDinoAttack();

            while ((robotTeam.robotList.Count > 0) && (dinoTeam.dinoList.Count > 0))
            
            {
                PrintAttributes();
                robotTeam.robotList[0].RobotAttack(dinoTeam.dinoList[0]);
                robotTeam.robotList[0].RobotPowerLoss();
                CheckBattleWinner();

                dinoTeam.dinoList[0].DinoAttack(robotTeam.robotList[0]);
                dinoTeam.dinoList[0].DinoEnergyLoss();
                CheckBattleWinner();

                Console.Write("Press Enter to Attack: \n");
                Console.ReadLine();
            }

            DisplayGameWinner();
        }
        
        public void PrintAttributes()
        {
            Console.WriteLine("Battle {0}: Robot {1} \t\t\t\t vs \t\t\t\t Dinosaur {2}", i + 1, robotTeam.robotList[0].robotName,
                    dinoTeam.dinoList[0].dinosaurType);

            Console.WriteLine("Robot Health: {1} \t\t\t\t vs \t\t\t\t Dinosaur Health: {2}", i + 1, robotTeam.robotList[0].robotHealth,
                    dinoTeam.dinoList[0].dinosaurHealth);

            Console.WriteLine("Robot Power Level: {1} \t\t\t\t vs \t\t\t\t Dinosaur Energy: {2}", i + 1, robotTeam.robotList[0].robotPowerLevel,
                    dinoTeam.dinoList[0].dinosaurEnergy);

            Console.WriteLine("Robot Weapon: {1} \t\t\t\t vs \t\t\t\t Dinosaur Attack: {2}", i + 1, robotTeam.robotList[0].robotWeapon.weaponType,
                        dinoAttack);

            Console.WriteLine("Robot Attack Power {1} \t\t\t\t vs \t\t\t\t Dinosaur Attack Power {2}\n", i + 1, robotTeam.robotList[0].robotWeapon.weaponAttackPower,
                        dinoTeam.dinoList[0].dinosaurAttackPower);
        }

        public void CheckBattleWinner()
        {
            if ((robotTeam.robotList[0].robotHealth <= 0) || (dinoTeam.dinoList[0].dinosaurHealth <= 0))
            {
                if (dinoTeam.dinoList[0].dinosaurHealth <= 0)
                {
                    Console.WriteLine("Robot {0} Defeated Dinosaur {1}\n", robotTeam.robotList[0].robotName, dinoTeam.dinoList[0].dinosaurType);
                    dinoTeam.dinoList.RemoveAt(0);
                    i++;
                    if (dinoTeam.dinoList.Count > 0)
                    {
                        dinoAttack = dinoTeam.dinoList[0].SelectDinoAttack();
                    }
                    //PrintAttributes();
                }
                
                if (robotTeam.robotList[0].robotHealth <= 0)
                {
                    Console.WriteLine("Dinosaur {0} Defeated Robot {1}\n", dinoTeam.dinoList[0].dinosaurType, robotTeam.robotList[0].robotName);
                    robotTeam.robotList.RemoveAt(0);
                    i++;
                }
            }
        }

        void DisplayGameWinner()
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
