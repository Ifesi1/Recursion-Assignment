using System;
using System.Diagnostics;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the minimum boundary number");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum boundary number");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Your checker must be between the minimum and the maximum boundary numbers ");
            Console.Write("Enter the number you wish to use as a checker: ");
            int checker = int.Parse(Console.ReadLine());

            if (min>max)
            {
                (min, max) = (max, min);
                PrintRandomNumbers(min, max, checker);
            }
            else
            {
                PrintRandomNumbers(min, max, checker);
            }
        }

        static void PrintRandomNumbers(int min,int max, int checker)
        {
            Random random = new Random();
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            int number = random.Next(min, max);
            while (number!=checker)
            {
                Console.WriteLine(number);
                number = random.Next(min, max);
            }
            Console.WriteLine(number);
            sw.Stop();
            Console.WriteLine("The elapsed time is {0} milli-seconds", sw.ElapsedMilliseconds);
        }

    }  
}
