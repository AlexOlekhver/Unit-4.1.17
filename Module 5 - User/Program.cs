using System;

namespace Module_5___User
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] dishes) User;
            Console.WriteLine("Print your mane : ");
            User.name = Console.ReadLine();

            User.dishes = new string[5];
            for (int i =0; i < User.dishes.Length;  i++ )
            {
                Console.WriteLine("Please insert your favorite dish {0}: ", i+1);
                User.dishes[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
