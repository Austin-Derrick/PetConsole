using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Status
    {        public static void CheckExp()
        {
            if (Pet.petEXP >= 100)
            {
                if (Pet.petEXP >= 200)
                {
                    if (Player.PetChoice == 1)
                    {
                        Util.WriteColoredText($"{Pet.petName} is evolving into a Dragon!", ConsoleColor.DarkRed);
                    }
                    else if (Player.PetChoice == 2)
                    {
                        Util.WriteColoredText($"{Pet.petName} is evolving into a Unicorn!", ConsoleColor.DarkMagenta);
                    }
                    else if (Player.PetChoice == 3)
                    {
                        Util.WriteColoredText($"{Pet.petName} is evolving into a Great Wolf!", ConsoleColor.DarkCyan);
                    }
                    Pet.Level = 3;
                    Util.Continue();
                    return;
                }
                if (Player.PetChoice == 1)
                {
                    Util.WriteColoredText($"Your {Pet.petName} is evolving into a Drake!", ConsoleColor.DarkYellow);
                }
                else if (Player.PetChoice == 2)
                {
                    Util.WriteColoredText($"Your {Pet.petName} is evolving into an adult horse!", ConsoleColor.Magenta);
                }
                else if (Player.PetChoice == 3)
                {
                    Util.WriteColoredText($"Your {Pet.petName} is evolving into an adult Wolf!", ConsoleColor.Cyan);
                }
            }
            Util.Continue();
            Pet.Level = 2;
            return;
        }
    }
}
