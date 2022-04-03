using System;

namespace Assingment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to check its sum down till 1:   ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(num));
        }

        static int Sum(int num)
        {
            if (num<=0)
            {
                return 0;
            }
            else
            {
                return num += Sum(num - 1);
            }
        }
    }
}
