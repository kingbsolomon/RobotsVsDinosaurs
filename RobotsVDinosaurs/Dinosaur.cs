using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string dinosaurType;
        public int dinosaurHealth;
        public int dinosaurEnergy;
        public int dinosaurAttackPower;

        public List<string> dinoAttack = new List<string>() { "Bite", "Claw", "Dino Slam", "Tail Whip", "Roar" };

        //Constructor
        public Dinosaur(string dinosaurType, int dinosaurHealth, int dinosaurEnergy, int dinosaurAttackPower)
        {
            this.dinosaurType = dinosaurType;
            this.dinosaurHealth = dinosaurHealth;
            this.dinosaurEnergy = dinosaurEnergy;
            this.dinosaurAttackPower = dinosaurAttackPower;
        }



        //Methods
        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= dinosaurAttackPower;
        }

        public void DinoEnergyLoss()
        {
            dinosaurEnergy -= 10;
        }

        public string SelectDinoAttack()
        {
            string attackSelection = "";
            Console.WriteLine("Please Select Your Dinosaur Attack from the list of options: ");
            Console.WriteLine("1: {0}, 2: {1} 3: {2} 4: {3} 5: {4}", dinoAttack[0], dinoAttack[1], dinoAttack[2], dinoAttack[3], dinoAttack[4]);
            string selectOption = Console.ReadLine();
           
            switch (selectOption)
            {
                case "1":
                    attackSelection = dinoAttack[0];
                    break;

                case "2":
                    attackSelection = dinoAttack[1];
                    break;

                case "3":
                    attackSelection = dinoAttack[2];
                    break;

                case "4":
                    attackSelection = dinoAttack[3];
                    break;

                case "5":
                    attackSelection = dinoAttack[4];
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice");
                    break;
            }

            return attackSelection;
        }
    }
}
