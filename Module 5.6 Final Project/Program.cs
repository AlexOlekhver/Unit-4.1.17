using System;

namespace Module_5._6_Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string SecondName, int Age, bool AvailPets, string[] NamePets, string[] FavFlow) User;

            Console.WriteLine("Please insert your name: ");
            User.Name = Console.ReadLine();
            
            Console.WriteLine("Please insert your Second Name: ");
            User.SecondName = Console.ReadLine();
            
            Console.WriteLine("Please insert your age? Please insert numbers.");
            User.Age = int.Parse(Console.ReadLine());
            TryParseAge(User.Age);

            Console.WriteLine("Is it true that you have a pets? true or false");
            User.AvailPets = bool.Parse(Console.ReadLine());

            if (User.AvailPets == true)
            {
                Console.WriteLine("How many pets do you have?");
                int CountPets = int.Parse(Console.ReadLine());
                TryParsePets(CountPets);
                Pets(CountPets);
            }
            Console.WriteLine("What is the number of your favorite colors?");
            int numflow = int.Parse(Console.ReadLine());
            TryParseNumflow(numflow);
            FavFlowers(numflow);
            
            ShowUser(User);
        }

        static string[] Pets(int CountPets)
        {
            var NamePets = new string[CountPets];

            for (int i = 0; i < CountPets; i++)
            {
                Console.WriteLine("Please insert name of your {0} pet:", i+1);
                NamePets[i] = Console.ReadLine();
            }
            foreach (var item in NamePets)
            {
                Console.WriteLine();
            }
            return NamePets;
        }
        static string[] FavFlowers(int numflow)
        {
            var FavFlow = new string[numflow];
            for (int i=0; i < numflow; i++)
            {
                Console.WriteLine("Please insert you {0} favorite flower: ", i + 1);
                FavFlow[i] = Console.ReadLine();
            }
            return FavFlow;
        }

        static int TryParsePets(int CountPets)
        {
            if (CountPets < 0)
            {
                Console.WriteLine("You insert incorrect number of pets. Please recheck and insert again: ");
                CountPets = int.Parse(Console.ReadLine());
            }
            return CountPets;
        }

        static int TryParseAge(int Age)
        {
            if (Age < 0)
            {
                Console.WriteLine("You insert incorrect age number. Please recheck and insert again: ");
                Age = int.Parse(Console.ReadLine());
            }
            return Age;
        }

        static int TryParseNumflow(int numflow)
        {
            if (numflow < 0)
            {
                Console.WriteLine("You insert incorrect number of your favorite flowers. Please recheck and insert again: ");
                numflow = int.Parse(Console.ReadLine());
            }
            return numflow;
        }

        static void (string Name, string SecondName, int Age, bool AvailPets, string[] NamePets, string[] FavFlow) ShowUser(User)
        {
            foreach (var item in User)
            {
                Console.WriteLine(item);
            }
        }
    }
}
