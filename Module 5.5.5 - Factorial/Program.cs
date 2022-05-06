using System;

namespace Module_5._5._5___Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение икс:");
            int x = int.Parse(Console.ReadLine()); 
            Factorial(x);
            Console.WriteLine(Factorial(x));
        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
