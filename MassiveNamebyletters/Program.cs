using System;

namespace MassiveNamebyletters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            for ( int i = name.Length - 1; i >= 0; i-- )
            {
                Console.Write(name[i]+ " ");
            }
            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length-1]);
            Console.ReadKey();
        }
    }
}
