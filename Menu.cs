using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Menu
    {
        public static int choice = 0;
        public Menu()
        {
            Console.WriteLine("\t\tWelcome to Beast Tamer!\n\n");
            Console.WriteLine("As a player you have the option to choose a creature that you would like to make your pet.\nNot only do you get a pet but you get to do activities with your pet that will give it more\nexperience.Collect a lot of experience and something awesome might happen!\n");
            presentMenu();
        }

        public static void presentMenu()
        {
            Console.WriteLine("\n\nPress any of the following to continue:\n\n1:\tAdopt-a-beast\n2:\tAbout\n3:\tQuit");
            choice = Util.inputCheck(1, 3, choice);

            switch(choice)
            {
                case 1:
                    Player player = new Player();
                    break;
                case 2:
                    Console.WriteLine("\tThis program lets you adopt a fun companion. Your options include a bearded dragon, a mini-horse, and a baby wolf. \n\tAfter choosing a beast to tame, you have the ability to name and do activites with you beast. \n\tDoing certain activities may give your pet experience points which may lead to something awesome!");
                    presentMenu();
                    Util.Continue();
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing!\n\nProgram by Austin Derrickson");
                    break;
                default:
                    presentMenu();
                    break;
            }
        }
    }
}
