using System;

namespace task._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 23, 56784, 788 };
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] / 100 >= 1 && array[i] / 100 < 10)
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine("3 reqemli eded var");
            }
            else
            {
                Console.WriteLine("3 reqemli eded yoxdur");
            }
        }
    }
}