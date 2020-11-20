using System;

namespace Lesson8Homework5
{
    class Program
    {
        public static int[] IncreaseArray(int[] array, int k)
        {
            int[] array_increase = new int [k + 1];
            for (int i = 0; i < k; i++)
            {
                array_increase[i] = array[i];
            }
            return array_increase;
        }
        public static int [] Array(int[] array,int value,int k)
        {
            int[] array2 = new int[k + 1];
            array2[1] = value;
            array2[0] = array[0];
            int j = 1;
            for (int i = 2; i < k + 1; i++)
            {
                array2[i] = array[j++];
            }
            return array2;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {2,3,4,5,6,7,8,9 };
            int[] array_increase = IncreaseArray(array, 8);
            for(int i=0;i<array_increase.Length; i++)
            {
                Console.WriteLine($"Array:{array_increase[i]}");
            }
            Console.WriteLine();
            int[] array2 = Array(array, 11, 8);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Array:{array2[i]}");
            }

        }
    }
}
