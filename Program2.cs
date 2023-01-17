using System;

namespace task._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 5, 7, 27, 13,};

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}

