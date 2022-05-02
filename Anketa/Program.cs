using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
        (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("What is name of your pet");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("What is the type of your pet");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("How old is your pet? Please write your reply in numbers");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("Your pets name is {0}", Pet.Name);
            Console.WriteLine("Your pet is {0}", Pet.Type);
            Console.WriteLine("Your pet is {0} years old", Pet.Age);
            Console.WriteLine("Your pet name has {0} letters", Pet.NameCount);

            Console.ReadKey();

        }
    }
}
