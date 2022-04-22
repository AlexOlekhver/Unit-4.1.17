using System;

namespace Project_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском маленькими буквами");
            
            var color = Console.ReadLine();
            
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("your favorite color red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("your favorite color green!");
                    break;

                case default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("your favorite color cyan!");
                    break;
            }
        }
    }
}
