//made by dnaj

using System;
using System.Linq;
using System.Threading;

namespace Generic_adventure
{
    class Stats
    {
        public const string name = "";
        public static int currentHealth = totalHealth;
        public static int totalHealth = 30;
        public static int currentXp = 0;
        public static int xpToLevelUp = 100;
        public static int level = 1;
        public static int money = 20;
        public static int inventorySlots = 9;
        public static int[] inventory = new int[inventorySlots];

        public static void LevelUp() {
            level++;
            inventorySlots = 14;
            Array.Resize(ref inventory, inventorySlots);
        }

        public static void AddToInventory(int id, int index = -1) {
            Items.ItemId(id);
            MC.Write("You received a", ConsoleColor.Green);
            MC.Write($" [{Items.name}]");
            MC.WriteLine("!!!", ConsoleColor.Green);
            MC.PressEnter();

            bool alreadyIn = false;
            if(inventory.Contains(0)) {
                if(index != -1) {
                    inventory[index] = id;
                } else {
                    for(int i = 0; i < inventory.Length; i++) {
                        if(inventory[i] == 0) {
                            if(!alreadyIn) {
                                inventory[i] = id;
                                alreadyIn = true;
                            }
                        }
                    }
                }
            } else {
            repeat:
                MC.WriteLine("Looks like your inventory is full!\nSelect an item to discard.", ConsoleColor.Green);
                Items.ItemId(id);
                MC.WriteLine($"( 1 ) Discard [{Items.name}]");
                ShowInventory(2);
                Console.WriteLine(MC.sep);
                int discard = MC.ChoiceMaker(1, inventory.Length + 1);
                Console.Clear();
                if (discard == 1) {
                    Items.ItemId(id);
                } else {
                    Items.ItemId(inventory[discard - 2]);
                }
                MC.Write("Are you sure you want to discard", ConsoleColor.Green);
                MC.Write($" [{Items.name}]");
                MC.WriteLine("?", ConsoleColor.Green);
                MC.Write("(This action cannot be undone)", ConsoleColor.DarkRed);
                MC.YesOrNo();
                Console.WriteLine(MC.sep);
                int temp = MC.ChoiceMaker();
                Console.Clear();
                if (temp == 2) {
                    goto repeat;
                } else {
                    if(discard != 1) { inventory[discard - 2] = id; }
                }
            }
            Console.Clear();
        }

        public static void ShowInventory(int offset = 1) {
            Console.WriteLine(MC.sep);
            for(int i = 0; i<inventory.Length; i++) {
                if (i < 10 - offset )
                    Console.Write($" 0{i + offset}. ");
                else
                Console.Write($" {i + offset}. ");
                if(inventory[i] == 0) {
                    MC.WriteLine("Vazio", ConsoleColor.DarkGray);
                } else {
                    Items.ItemId(inventory[i]);
                    Console.WriteLine(Items.name);
                }
            }
        }
    }
}
