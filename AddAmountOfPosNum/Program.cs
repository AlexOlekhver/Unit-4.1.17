using System;

namespace AddAmountOfPosNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {5, 6, -3, 6, -3, 6, -3, 6, -3, 5};
            var numbers = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    numbers++;
                }
            }
            Console.WriteLine(numbers);
            Console.ReadKey();
        }
    }
}
