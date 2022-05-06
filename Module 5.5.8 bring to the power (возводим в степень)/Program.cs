using System;

namespace Module_5._5._8_bring_to_the_power__возводим_в_степень_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение степени:");
            byte pow = byte.Parse(Console.ReadLine());
            PowerUp(N, pow);
            Console.WriteLine(PowerUp(N, pow));

        }
        private static int PowerUp (int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            } 
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}
