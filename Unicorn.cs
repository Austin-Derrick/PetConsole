using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Unicorn : Pet
    {
        public Unicorn()
        {
            petType = "mini-horse";
            petName = Util.ask("What would you like to call your mini-horse?");
            Console.Clear();
            Console.WriteLine("Great name! " + petName + " currently has " + petEXP + " Experience Points.");
            setMythology();
            setPetMoves();
        }

        public override void setMythology()
        {
            Mythology[0] = "Your mini-horse stands a wopping 2 feet tall. Capable of......eating grass and running 5mph at most.";
            Mythology[1] = "A full bred mustang, strong demanding of ones attention. It's defined muscles exude a sense of power.";
            Mythology[2] = "A single horn pertruding out of its head, this elusive yet graceful creature stands proud. One look into its eye sends feelings of grace and wisdom down ones spine.";
        }

        public override void setPetMoves()
        {
            petMoves[0] = "Head butt";
            petMoves[1] = "Stomp";
            petMoves[2] = "Charge";
            petMoves[3] = "Horn Shot";
        }
    }
}
