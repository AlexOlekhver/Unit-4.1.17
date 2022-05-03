using System;

namespace _5._1._6.___GetArray
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }
    
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
           {
            Console.WriteLine("Please insert element of massive no {0}", i + 1);
            result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
    }
}
