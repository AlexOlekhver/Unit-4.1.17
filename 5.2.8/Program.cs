using System;

namespace _5._2._8
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
        static int[] SortArray(int[] array)
        {
            array = GetArrayFromConsole();

            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            }
            return array;
        }

    }
}

