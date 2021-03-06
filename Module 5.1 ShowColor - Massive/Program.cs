using System;

namespace Module_5._1_ShowColor___Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ShowColor(string username, int userage)
            {
                Console.WriteLine("{0}, {1} years old \n Напишите свой любимый цвет на английском с маленькой буквы", username, userage);
                var color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                return color;
            }

            var (name, age) = ("Evgenuya", 27);

            Console.WriteLine("My name is {0}", name);
            Console.WriteLine(" My age is {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favColors = new string[3];
            for (int i = 0; i < favColors.Length ; i++)
                {
                    favColors[i] = ShowColor(name , age);
                }

            Console.WriteLine("Yours favorite colors are: ");
            foreach (var color in favColors)
                {
                    Console.WriteLine(color);
                }
          
            Console.ReadKey();
            }
        }    
    }

