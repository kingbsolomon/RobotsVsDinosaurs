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
          
            PrintAttributes();

            
           /* while(robotTeam.robotList.Count > 0 && dinoTeam.dinoList.Count > 0)
            {
                Robot robot = new Robot(robotTeam.robotList[i].robotName, robotTeam.robotList[i].robotHealth,
                    robotTeam.robotList[i].robotPowerLevel, robotTeam.robotList[i].robotWeapon);

                Dinosaur dino = new Dinosaur(dinoTeam.dinoList[i].dinosaurType, dinoTeam.dinoList[i].dinosaurHealth,
                    dinoTeam.dinoList[i].dinosaurEnergy, dinoTeam.dinoList[i].dinosaurAttackPower);

                Console.WriteLine("Battle {0}: Robot {1} vs Dinosaur {2}",i+1,robotTeam.robotList[i].robotName,
                    dinoTeam.dinoList[i].dinosaurType);

                robot.RobotAttack(dino);
                dino.DinoAttack(robot);
                PrintA


            }*/
           


        }
        
        public void PrintAttributes()
        {
            Console.WriteLine("Battle {0}: Robot {1} \t\t\t vs \t\t\t Dinosaur {2}", i + 1, robotTeam.robotList[i].robotName,
                    dinoTeam.dinoList[i].dinosaurType);

            Console.WriteLine("Robot Health: {1} \t\t\t vs \t\t\t Dinosaur Health: {2}", i + 1, robotTeam.robotList[i].robotHealth,
                    dinoTeam.dinoList[i].dinosaurHealth);

            Console.WriteLine("Robot Power Level: {1} \t\t\t vs \t\t\t Dinosaur Energy: {2}", i + 1, robotTeam.robotList[i].robotPowerLevel,
                    dinoTeam.dinoList[i].dinosaurEnergy);

            Console.WriteLine("Robot Attack Power {1} \t\t\t vs \t\t\t Dinosaur Attack Power {2}", i + 1, robotTeam.robotList[i].robotWeapon.weaponAttackPower,
                        dinoTeam.dinoList[i].dinosaurAttackPower);
        }
           
    }
}
