using System;

namespace Lesson8Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array:");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)//заповнюємо масив
            {
                Console.WriteLine("Enter array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            int min = array[0];
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]>max)
                {
                    max = array[i];
                }
                else if(array[i]<min)
                {
                    min = array[i];
                }
                    sum += array[i];
            }
            double avg = sum / size;

            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Sum:{sum}");
            Console.WriteLine($"Avg:{avg}");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd number:{array[i]}");
                }
            }
        }
    }
}
