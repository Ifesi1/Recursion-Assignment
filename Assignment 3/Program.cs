using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int startnumber = 1;
            Console.WriteLine("This displays prime numbers from 1 to any number you enter");
            Console.WriteLine("Please enter the range of numbers you want");
            int lastnumber = int.Parse(Console.ReadLine());

            PrintAnotherPrime(startnumber, lastnumber);
            Console.WriteLine();
        }

        static void PrintAnotherPrime(int startnum, int lastnum)
        {
            if (lastnum <= 0)
            {
                Console.WriteLine("0");
            }
            else if (lastnum >= 1)
            {
                for (int i = 2; i < lastnum; i++)
                {
                    int holder = 1;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            holder = 0;
                            break;
                        }
                    }
                    if (holder == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                PrintAnotherPrime(startnum + 1, lastnum);

            }
        }
    }
}
