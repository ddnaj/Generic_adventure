//made by dnaj

using System;
using System.Threading;

namespace Generic_adventure
{
    class Items
    {
        public static int id;
        public static string name;
        public static string description;
        public static int damage;

        public static void ItemId(int id) {
            switch(id) {
                case 1:
                name = "Bare fists";
                description = "Just ur hands lol.";
                damage = 1;
                break;
                case 2:
                name = "Wooden Sword";
                description = "Plain wooden sword. Looks like a toy tho.";
                damage = 2;
                break;
                case 3:
                name = "Stone Sword";
                description = "Literally a piece of stone. Can we actually call this a sword?";
                damage = 4;
                break;
                case 4:
                name = "Iron Sword";
                description = "An average sword found in an ordinary blacksmith.";
                damage = 10;
                break;
                case 5:
                name = "Steel Sword";
                description = "Higher quality than Iron Swords, as durable as it gets.";
                damage = 14;
                break;
                case 6:
                name = "Titanium Sword";
                description = "Only some blacksmiths can make this sword in the entire world,\n" +
                    "wielding it is like holding a piece of art.";
                damage = 20;
                break;
                case 7:
                name = "Obisidian Sword";
                description = "Very few people in the world even get to know that this sword exists.\n" +
                    "Calling it magnificent would be a modest act.";
                damage = 28;
                break;
                case 8:
                name = "Master Sword";
                description = "Sounds familiar and looks familiar, but you really don't know from where";
                damage = 32;
                break;
                case 9:
                name = "Excalibur";
                description = "It's fucking Excalibur.";
                damage = 99;
                break;
                case 10:
                name = "DOGE SWORD";
                description = "WOW SUCH DOGE";
                damage = 69420;
                break;
            }
        }
    }
}
