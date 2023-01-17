using System;

namespace task._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine(a);
                }
                else Console.WriteLine(c);
            }
            else if (b < a)
            {
                if (b < c)
                    Console.WriteLine(b);
            }
            else Console.WriteLine(c);
        }
    }
}

