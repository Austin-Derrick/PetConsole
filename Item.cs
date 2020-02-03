using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Virtual_Pet_Prototype
{
    class Item : IDescribe
    {
        public string itemName = "";
        public int itemPrice = 0;
        public string itemDescription = "";
        public List<string> itemDescriptions = new List<string>();
        public string filePath = "../../itemDescription.txt";
        public List<string> itemNames = new List<string>();
        public string filePath2 = "../../itemNames.txt";

        public Item()
        {
            itemDescriptions = File.ReadAllLines(filePath).ToList();
            itemNames = File.ReadAllLines(filePath2).ToList();
        }

        public string describe(string input)
        {
            string _string = input;
            return _string;
        }
    }
}
