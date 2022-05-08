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
            string username = User.Name;


            Console.WriteLine("Please insert your Second Name: ");
            User.SecondName = Console.ReadLine();
            string secondname = User.SecondName;
            
            Console.WriteLine("Please insert your age? Please insert numbers.");
            User.Age = int.Parse(Console.ReadLine());
            TryParseAge(User.Age);
            int age = User.Age;

            Console.WriteLine("Is it true that you have a pets? true or false");
            User.AvailPets = bool.Parse(Console.ReadLine());
            int CountPets = 0;
            if (User.AvailPets == true)
            {
                Console.WriteLine("How many pets do you have?");
                CountPets = int.Parse(Console.ReadLine());
                TryParsePets(CountPets);
            }
            string[] pets = Pets(CountPets);

            Console.WriteLine("What is the number of your favorite colors?");
            int numflow = int.Parse(Console.ReadLine());
            TryParseNumflow(numflow);
            string[] favflow = FavFlowers(numflow);
            

            ShowUser(username, secondname, age, CountPets, pets, favflow);
            Console.ReadKey();
        }

        static string[] Pets(int CountPets)
        {
            var NamePets = new string[CountPets];

            for (int i = 0; i < CountPets; i++)
            {
                Console.WriteLine("Please insert name of your {0} pet:", i+1);
                NamePets[i] = Console.ReadLine();
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

        static void ShowUser(string username, string secondname, int age, int CountPets, string[] pets, string[] favflow)
        {
            Console.WriteLine("Name: {0}", username);
            Console.WriteLine("SecondName: {0}", secondname);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("You have {0} pets", CountPets);
            Console.WriteLine(" Names of your pets:");
            for ( int i = 0; i < CountPets; i++)
            {
                Console.WriteLine(pets[i]);
            }

            Console.WriteLine("your favorite colors are:");
            for (int i = 0; i < favflow.Length; i++)
            {
                Console.WriteLine(favflow[i]);
            }
        }
    }
}
