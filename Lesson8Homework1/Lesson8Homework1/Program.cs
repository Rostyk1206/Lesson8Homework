using System;

namespace Lesson8Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for(int i=array.Length-1;i>=0;i--)
            {
                Console.WriteLine($"{array[i]}");
            }
            Console.ReadLine();
        }
    }
}
