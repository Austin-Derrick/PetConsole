using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Dragon : Pet
    {
        public Dragon()
        {
            petType = "bearder dragon";
            petName = Util.ask("What would you like to call your bearded dragon?");
            Console.Clear();
            Console.WriteLine("Great name! " + petName + " currently has " + petEXP + " Experience Points.");
            setMythology();
            setPetMoves();
        }

        public override void setMythology()
        {
            Mythology[0] = "the underside of the throat which can turn black for a number of reasons most often is a sign of stress.They are adept climbers, spending significant amounts of time on branches and in bushes and near human habitation\n\nSource:https://en.wikipedia.org/wiki/Pogona#Behaviour";
            Mythology[1] = "A Drake is a large, serpent-like legendary creature that appears in the folklore of many cultures around the world. Beliefs about dragons vary drastically by region, but dragons in western cultures since the High Middle Ages have often been depicted as winged, horned, four-legged, and capable of breathing fire.\n\nSource: https://en.wikipedia.org/wiki/Dragon";
            Mythology[2] = "Stories of dragons travel from everyland, varying based on culture but all share the same ability to strike fear into whomever enters its territory. Your dragon is one forged in fire, capable of breathing fire as large as a buidling and flying at incredible speeds.";
        }

        public override void setPetMoves()
        {
            petMoves[0] = "Bite";
            petMoves[1] = "Claw";
            petMoves[2] = "Fire Breath";
            petMoves[3] = "Nova Cannon";
        }
    }
}
