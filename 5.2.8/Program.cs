using System;

namespace _5._2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            var array = GetArrayFromConsole(ref num);
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

        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Please insert element of massive no {0}", i + 1);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
        static void SortArray(in int[] array, out int[] sortdesc, out int[] sortdasc )
        {
            sortdesc = SortArrayDesc(array);
            sortdasc = SortArrayAsc(array);

        }    
        static int[] SortArrayDesc(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            }
            return array;
        }
        static int[] SortArrayAsc(in int[] array)
        {
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

