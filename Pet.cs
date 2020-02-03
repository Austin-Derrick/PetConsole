using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Virtual_Pet_Prototype
{
    class Pet
    {
        int PlayerChoice = Player.PetChoice;
        public static string petName = "";
        public static string petType = "";
        public static int petEXP = 0;
        public static int petEnergy = 100;
        public static int petHealth = 100;
        public static int Level = 1;
        public static string[] Mythology = { "", "", "" };
        public static string[] petMoves = { "", "", "", "" };

        public int getPetHealth()
        {
            return Pet.petHealth;
        }

        public virtual void setMythology()
        {
            Mythology[0] = "Your Pets Mythology";
            Mythology[1] = "Your Pets Mythology";
            Mythology[2] = "Your Pets Mythology";
        }

        public virtual void setPetMoves()
        {
            petMoves[0] = "";
            petMoves[1] = "";
            petMoves[2] = "";
            petMoves[3] = "";
        }
    }

}
