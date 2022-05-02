using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 3; k++)
            {
                (string Name, string LastName, string Login, int LoginCount, bool Pet, double Age, string[] FavColors) User;

                Console.WriteLine("What is your name?");
                User.Name = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                User.LastName = Console.ReadLine();

                Console.WriteLine("What is your login?");
                User.Login = Console.ReadLine();
                User.LoginCount = User.Login.Length;

                Console.WriteLine("Do you have pet? Yes or No?");
                var result = Console.ReadLine();
                if (result == "Yes")
                {
                    User.Pet = true;
                }
                else
                {
                    User.Pet = false;
                }

                Console.WriteLine("How old are you?");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.FavColors = new string[3];
                Console.WriteLine("Please specify your 3 favorites colors");
                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }
            }
      
            Console.ReadKey();
        }
    }
}
