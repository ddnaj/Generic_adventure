//made by dnaj

using System;
using System.Threading;

namespace Generic_adventure
{
    class MC
    {
        public const string sep = "-----------------------------"; //separator
        public const string erMsg = "Something went wrong... try again:"; //error message

        //Console.Write with color parameter
        public static void Write(string text, ConsoleColor color = ConsoleColor.Gray) {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Console.WriteLine with color parameter
        public static void WriteLine(string text, ConsoleColor color = ConsoleColor.Gray) {
            Console.ForegroundColor = color;
            Console.Write($"{text}\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Player answer to choice inputs
        public static string Answer(ConsoleColor color = ConsoleColor.Cyan) {
            Console.ForegroundColor = color;
            string temp = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            return temp;
        }

        //Create a list of items
        public static void CreateList(string[] items, ConsoleColor color = ConsoleColor.Gray) {
            Console.WriteLine($"\n {sep}");
            for(int i = 1; i < items.Length + 1; i++) {
                if(i < 10)
                    Console.Write($" 0{i}. ");
                else
                    Write($"{i}. ");
                WriteLine(items[i - 1], color);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(sep);
        }

        //Creates a Yes or No list
        public static void YesOrNo() {
            Console.WriteLine($"\n {sep}");
            string[] items = new string[] { "Yes", "No" };
            for(int i = 1; i < items.Length + 1; i++) {
                WriteLine($"0{i}. {items[i - 1]} ");
            }
        }

        //Writes with delay, but angry
        public static void AngryWrite(string text, ConsoleColor color = ConsoleColor.Green) {
            Console.ForegroundColor = color;
            Random rnd = new();
            foreach(char c in text) {
                Console.Write(c);
                Thread.Sleep(rnd.Next(10, 30));
            }
            Thread.Sleep(150);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Writes with delay
        public static void SlowWrite(string text, ConsoleColor color = ConsoleColor.Green) {
            Console.ForegroundColor = color;
            Random rnd = new();
            foreach(char c in text) {
                Console.Write(c);
                Thread.Sleep(rnd.Next(30, 60));
            }
            Thread.Sleep(150);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Writes with even fucking more delay
        public static void VerySlowWrite(string text, ConsoleColor color = ConsoleColor.Green) {
            Console.ForegroundColor = color;
            Thread.Sleep(900);
            foreach(char c in text) {
                Console.Write(c);
                Thread.Sleep(400);
            }
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Clear lines from console
        public static void ClearLine(int qtd = 1) {
            for(int i = 0; i < qtd; i++) {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }
        }
 
        //Press enter to continue
        public static void PressEnter(int mode = 1) {
            Console.WriteLine($"{sep}\nPress ENTER to continue");
            do {} while(Console.ReadKey(true).Key != ConsoleKey.Enter);
            if (mode == 1) {
                Console.Clear();
            } else {
                ClearLine(2);
            }
        }

        //Input check
        public static int ChoiceMaker(int min = 1, int max = 2) {
            bool error = true;
        start:
            string test = Answer();
            if(!int.TryParse(test, out _)) {
                ClearLine(1);
                if(error) { WriteLine(erMsg, ConsoleColor.Green); }
                error = false;
                goto start;
            }
            int choice = Convert.ToInt32(test);
            if(choice <= max && choice >= min) {
                return choice;
            } else {
                ClearLine(1);
                if(error) { WriteLine(erMsg, ConsoleColor.Green); }
                error = false;
                goto start;
            }
        }
    }
}