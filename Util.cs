using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace Virtual_Pet_Prototype
{
    class Util
    {
        public static int RandomNum;
        
        public Util()
        {
            
        }

        public static string ask(string question)
        {
            WriteLine(question);
            return ReadLine();
        }
        
        public static int inputCheck(int min, int max, int input)
        {
            input = int.Parse(Console.ReadLine());
            while (input <  min || input > max)
            {
                Util.WriteColoredText($"Invalid Input - please type a number between {min} and {max}", ConsoleColor.Red);
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }

        public static void WriteColoredText(string _string, ConsoleColor _foregroundColor)
        {
            ConsoleColor preExistingForegroundColor = ForegroundColor;
            ForegroundColor = _foregroundColor;
            WriteLine(_string);
            ForegroundColor = preExistingForegroundColor;
        }

        public static int getRandomNumber(int min, int max)
        {
            Random RandNum = new Random();
            return RandNum.Next(min, max);
        }
        public static void Continue()
        {
            WriteLine("Press any key to continue...");
            ReadKey();
            Clear();
        }
        public static string getEnemy()
        {
            string filePath = @"../../Enemies.txt";
            List<string> Enemies = File.ReadAllLines(filePath).ToList();
            string[] battleEnemy = new string[10];
            for (int i = 0; i < 10;)
            {
                foreach (var line in Enemies)
                {
                    battleEnemy[i] = line;
                    i++;
                }
            }
            
            RandomNum = getRandomNumber(0, 9);
            return battleEnemy[RandomNum];
        }
    }
}
