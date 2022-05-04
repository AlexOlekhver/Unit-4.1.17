using System;

namespace _5._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);
        }

        static void ShowArray(int[] array, bool Sort = false)
        {
            var temp = array;
            if (Sort)
            {
                temp = SortArray(array);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Please insert element of massive no {0}", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] result)
        {
            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            }
            return result;
        }

    }
}

