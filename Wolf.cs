using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Wolf : Pet
    {
        public Wolf()
        {
            petType = "baby wolf";
            petName = Util.ask("What would you like to call your baby wolf?");
            Console.Clear();
            Console.WriteLine("Great name! " + petName + " currently has " + petEXP + " Experience Points.");
            setMythology();
            setPetMoves();
        }

        public override void setMythology()
        {
            Mythology[0] = "A poor baby wolf, smaller than normal but what it lacks in size it makes up for in cuddles <3";
            Mythology[1] = "A full grown wolf, standing 6ft tall, 300 pounds of pure deadly fluff.";
            Mythology[2] = "Fenrir,a monstrous wolf of Norse mythology. He was the son of the demoniac god Loki and a giantess, Angerboda. Knowing only battle, fenrirs ability in battle is equal to its wisdom.";
        }

        public override void setPetMoves()
        {
            petMoves[0] = "Scratch";
            petMoves[1] = "Bite";
            petMoves[2] = "Howl";
            petMoves[3] = "Razor Claw";
        }
    }
}
