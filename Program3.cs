using System;

namespace task._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 17, 18, 30, 34, 40};
            int sum = 0;
            double count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%3==0)
                {
                    sum = sum + array[i];
                    count++;
                }
            }
            if (count==0)
            {
                Console.WriteLine("3-e bolunen eded yoxdur");
            }
            else
            {
                Console.WriteLine(sum / count);
            }
        }
    }
}

