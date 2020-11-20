using System;

namespace Lesson8Homework3
{
    class Program
    {
        public static int[] MyReverse (ref int[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            return array;
        }
        public static int[] SubArray(int[] array, int index, int count)
        {
            int[] array1 = new int[count];
            for(int i=index;i<count;i++)
            {
                for(int j=0;j<count;j++)
                {
                    if(array[j]==0)
                    {
                        array[j] = 1;
                    }
                }
            }
            return array1;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int[] array2 = MyReverse(ref array);
            int[] array3 = SubArray(array, 1, 4);
            for (int i=0;i<array3.Length;i++)
            {
                Console.WriteLine($"SubArray:{array3[i]}");
            }
        }
    }
}
