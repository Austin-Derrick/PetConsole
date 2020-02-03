using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Battle
    {
        int enemyHealth = 0;
        public static int choice;
        public Battle()
        {
            displayBattle();
            printResults();
        }

        public void displayBattle()
        {
            string Enemy = Util.getEnemy();
            enemyHealth = Util.getRandomNumber(5, 20);
            while (enemyHealth > 0)
            {
                if (Pet.petHealth < 0)
                {
                    Util.WriteColoredText("Your pet lost!, returning to choices", ConsoleColor.Red);
                    Pet.petHealth = 50;
                    Player.PetOptions();
                }
                else
                {
                    Console.Clear();
                    Util.WriteColoredText($"{ Pet.petName} is fighting {Enemy}\t", ConsoleColor.Red);
                    Console.WriteLine($"{Pet.petName}'s health: {Pet.petHealth}\t {Enemy}'s health: {enemyHealth}");
                    Console.WriteLine("What move would you like to use?\n");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"\t{(i + 1)}: {Pet.petMoves[i]}");
                    }
                    getMove();
                }
            }
        }

        public void getMove()
        {
            switch(Pet.Level)
            {
                case 1:
                    choice = inputCheck(1, 1, choice);
                    enemyHealth = enemyHealth - Util.getRandomNumber(2, 5);
                    break;
                case 2 & 3:
                    choice = inputCheck(1, 3, choice);
                    enemyHealth = enemyHealth - Util.getRandomNumber(5, 12);
                    break;
                case 4:
                    choice = inputCheck(1, 4, choice);
                    enemyHealth = enemyHealth - Util.getRandomNumber(10, 20); ;
                    break;
            }
            Pet.petHealth = Pet.petHealth - Util.getRandomNumber(3, 15);
        }

        public void printResults()
        {
            Pet.petEXP = Pet.petEXP + 120;
            Pet.petEnergy = Pet.petEnergy - 20;
            Player.gold = Player.gold + Util.getRandomNumber(1, 10);
            Console.WriteLine($"{Pet.petName} earned 20 Experience Points!\n\tCurrently EXP: { Pet.petEXP }\n\tCurrent Energy: { Pet.petEnergy }");
            Util.WriteColoredText($"\tPlayer gold: {Player.gold.ToString()}", ConsoleColor.Yellow);
            Util.Continue();
        }

        public static int inputCheck(int min, int max, int input)
        {
            input = int.Parse(Console.ReadLine());
            while (input < min || input > max)
            {
                Util.WriteColoredText($"Your beasts level is too low to use that move - please type a number between {min} and {max}", ConsoleColor.Red);
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}
