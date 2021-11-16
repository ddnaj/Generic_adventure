//made by dnaj

using System;
using System.Threading;

namespace Generic_adventure
{
    class TL
    {

        static void Main() {
            Items.ItemId(1);
            Console.WriteLine(Items.name);
            Console.WriteLine(Items.description);

            Stats.ShowInventory();

            Stats.AddToInventory(1);
            Stats.AddToInventory(2);
            Stats.AddToInventory(3);
            Stats.AddToInventory(4);
            Stats.AddToInventory(5);
            Stats.AddToInventory(6);
            Stats.AddToInventory(7);
            Stats.AddToInventory(8);
            Stats.AddToInventory(9);
            Stats.AddToInventory(10);

            Stats.ShowInventory();

            // Stops program
            Console.ReadKey();
        }
        static void Tutorial() {
            MC.Write("Hey!", ConsoleColor.Green);
            MC.PressEnter();
            MC.SlowWrite("Hey!!!!");
            MC.PressEnter();
            MC.VerySlowWrite("...");
            MC.PressEnter();
            MC.AngryWrite("I'M RIGHT HERE DUMBASS!!!!!");
            MC.PressEnter();
            MC.SlowWrite("What are you doing lying here in this forest? \nDidn't you hear about the monsters that roam around here???");
            MC.PressEnter();
            MC.VerySlowWrite("...");
            MC.PressEnter();
            MC.SlowWrite("Can you please answer my questions?");
            MC.PressEnter();
            MC.SlowWrite("Ok.");
            Thread.Sleep(1500);
            MC.SlowWrite("\nLook, I'm in a really great mood today so i will\njust assume that you don't know how to talk.");
            MC.PressEnter();
            MC.SlowWrite("Here, let's try something.");
            MC.PressEnter();
            MC.SlowWrite("When someone talks with you, \nyou have a few options to choose from.");
            MC.PressEnter();
        rep:
            MC.SlowWrite("Listen closely: What is the favorite food of a monkey?");
            MC.CreateList(new string[] { "Banana", "Garbage", "The entire Empire State Building" }, ConsoleColor.Cyan);
            int temp = MC.ChoiceMaker(1, 3);
            while(temp != 1) {
                Console.Clear();
                MC.SlowWrite("So you're just an idiot.");
                MC.PressEnter();
                MC.SlowWrite("Ok. Maybe i'm being too harsh, let's try again.");
                MC.PressEnter();
                goto rep;
            }
            Console.Clear();
            MC.SlowWrite("Right!!! It is!!!");
            MC.PressEnter();
            MC.VerySlowWrite("..?");
            MC.CreateList(new string[] { "What happened?", "Is there something wrong?" }, ConsoleColor.Cyan);
            MC.ChoiceMaker();
            Console.Clear();
            MC.SlowWrite("Shhhhhh! Can't you hear it??\nThere's a monster nearby!!");
            MC.PressEnter();
            MC.SlowWrite("Here, take this to protect yourself.");
            MC.PressEnter();
            Stats.AddToInventory(2);
        }
    }
}
