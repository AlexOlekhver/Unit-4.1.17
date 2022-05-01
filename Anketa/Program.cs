using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Aleksei", 42);
            
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            Console.ReadKey();
        }
    }
}
