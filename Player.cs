using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Virtual_Pet_Prototype
{
    class Player
    {
        public string PlayerName;
        public static int PetChoice = 0;
        public static int gold = 1;

        public Player()
        {
            PlayerName = Util.ask("Welcome Player! What would you like to be called?");
            Clear();
            WriteLine("Welcome " + PlayerName + "!\n");

            choosePet();
            PetOptions();
        }

        public static void choosePet()
        {
            WriteLine("\nYour choices for pets are as follows (For your pet choice please input a number, 1, 2, or 3, when making your choice):");
            WriteLine("\n\t1: A bearded dragon - a small reptile with a cute deamenor.");
            WriteLine("\n\t2: A mini-horse - a small dopey looking horse, will likely chew on hair");
            WriteLine("\n\t3: A baby wolf - a small wolf, most likely abandoned due to its small size.");
            WriteLine("\nPlease input your choice:");

            PetChoice = Util.inputCheck(1, 3, PetChoice);

            switch (PetChoice)
            {
                case 1:
                    Dragon dragon = new Dragon();
                    break;
                case 2:
                    Unicorn unicorn = new Unicorn();
                    break;
                case 3:
                    Wolf wolf = new Wolf();
                    break;
            }
        }

        public static void PetOptions()
        {
            int choice = 0;
            Console.WriteLine("\nOptions regarding your pet (For your pet choice please input a number, 1, 2, or 3, when making your choice):");
            Console.WriteLine($"\n\t1: Do activities with {Pet.petName}");
            Console.WriteLine($"\n\t2: Learn {Pet.petName}'s mythology");
            Console.WriteLine($"\n\t3: Display {Pet.petName}'s stats");
            Console.WriteLine($"\n\t4: Go to the store");
            Console.WriteLine($"\n\t5: Return to the main menu");
            choice = Util.inputCheck(1, 5, choice);

            switch(choice)
            {
                case 1:
                    Activities();
                    break;
                case 2:
                    Mythology();
                    break;
                case 3:
                    showStats();
                    break;
                case 4:
                    goToStore();
                    break;
                case 5:
                    Menu.presentMenu();
                    break;
            }
        }

        public static void goToStore()
        {
            Store store = new Store();
            Util.Continue();
            Clear();
            PetOptions();
        }

        public static void Mythology()
        {
            Console.WriteLine(Pet.Mythology[Pet.Level - 1]);
            Util.Continue();
            PetOptions();
        }

        public static void showStats()
        {
            WriteLine($"Name:\t {Pet.petName}");
            WriteLine($"Level:\t {Pet.Level}");
            WriteLine($"Experience points:\t {Pet.petEXP}");
            WriteLine($"Energy:\t {Pet.petEnergy}");
            Util.Continue();
            PetOptions();
        }

        public static void Activities()
        {
            int activity = 0;

            do
            {
                Console.WriteLine("What would you like to do with your " + Pet.petType + "?\n");
                Console.WriteLine("1: Fight monsters");
                Console.WriteLine("2: Eat");
                Console.WriteLine("3: Sleep");
                Console.WriteLine("4: Back to options");

                activity = Util.inputCheck(1, 4, activity);
                if(Pet.petEnergy < 1 && (activity == 1))
                {
                    Console.WriteLine($"{Pet.petName} is too tired to do any activities, try eating or sleeping.");
                    Activities();
                }
                switch(activity)
                {
                    case 1:
                        Battle battle = new Battle();
                        break;

                    case 2:
                        WriteLine(Pet.petName + " is currently eating a hearty meal...");
                        Pet.petEXP = Pet.petEXP + 10;
                        Pet.petEnergy = Pet.petEnergy + 10;
                        Pet.petHealth += Util.getRandomNumber(20,50);
                        WriteLine($"{ Pet.petName} earned 10 Experience Points!\n\tCurrent Health: {Pet.petHealth}\n\tCurrently EXP: {Pet.petEXP}\n\tCurrent Energy: {Pet.petEnergy}\t");
                        Util.Continue();
                        break;

                    case 3:
                        Pet.petEnergy = 100;
                        Pet.petEXP += 110;
                        Console.WriteLine(Pet.petName + " is currently sleeping soundly...");
                        Console.WriteLine("Would you like to wake " + Pet.petName + "? ( Y / N)");
                        string wake = Console.ReadLine().ToLower();
                        if (wake == "y")
                        {
                            Console.WriteLine(Pet.petName + " woke up!");
                        }
                        else
                        {
                            Console.WriteLine(Pet.petName + " is sleeping!");
                        }
                        break;
                }
                Status.CheckExp();
                Clear();
            } while (activity != 4);
            Clear();
            PetOptions();
        }
    }
}
