using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Prototype
{
    class Store
    {
        public static List<Item> inventory = new List<Item>();
        public Store()
        {
            stockInventory();
            displayInventory();
        }

        public void stockInventory()
        {
            if (inventory.Count < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                Item item = new Item();
                item.itemName = item.itemNames[i];
                item.itemPrice = (i+1) * 5;
                item.itemDescription = item.itemDescriptions[i];
                inventory.Add(item);
                }
            }
            else
            {

            }
            
        }

        public void displayInventory()
        {
            Console.WriteLine("Welcome to the store. What would you like to buy?");
            foreach (var item in inventory)
            {
                Console.WriteLine(item.describe($"{item.itemDescription} - {item.itemPrice}"));
            }
            getChoice();
            
        }

        public void getChoice()
        {
            int itemChoice = 0;
            itemChoice = Util.inputCheck(1, 5, itemChoice);
            // add if loop to check for player gold and price
            if (Player.gold < inventory[itemChoice - 1].itemPrice)
            {
                Util.WriteColoredText("Sorry you do not have enough gold for that item. Please try again later.", ConsoleColor.Red);
                Player.PetOptions();
            }
            switch(itemChoice)
            {
                case 1:
                    Util.WriteColoredText($"This fashionable hat gave {Pet.petName} an extra 20 energy!", ConsoleColor.Blue);
                    Pet.petEnergy += 20;
                    break;
                case 2:
                    Util.WriteColoredText($"This stylish jacket gave {Pet.petName} an extra 50 health!", ConsoleColor.Blue);
                    Pet.petHealth += 50;
                    break;
                case 3:
                    Util.WriteColoredText($"This hefty bone gave {Pet.petName} an extra 30 health and 30 energy!", ConsoleColor.Blue);
                    Pet.petHealth += 30;
                    Pet.petEnergy += 30;
                    break;
                case 4:
                    Util.WriteColoredText($"This delicious burger completely restored {Pet.petName}'s health!", ConsoleColor.Blue);
                    Pet.petHealth = 110;
                    break;
                case 5:
                    Util.WriteColoredText($"This fun toy completely restored {Pet.petName}'s energy!", ConsoleColor.Blue);
                    Pet.petEnergy = 110;
                    break;

            }
            Player.gold = Player.gold - inventory[itemChoice - 1].itemPrice;

            Util.WriteColoredText($"You now have {inventory[itemChoice - 1].itemName}", ConsoleColor.Blue);

            Util.WriteColoredText($"Remaining gold: {Player.gold}", ConsoleColor.Yellow);
        }
    }
}
