using System;

namespace Recursive_Prime_Numbers
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
            if (lastnum<=0)
            {
                Console.WriteLine("0");
            }
            else if(lastnum>=1)
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
static void Main(string[] args)
{
    //Console.Write("Enter a Number of your choice:  ");
    //int num = int.Parse(Console.ReadLine());
    //Console.WriteLine(" ");
    //Console.WriteLine("The Prime numbers from {0} to {1} are listed below", 1, num);
    //Console.Write(PrimeNumber(num)+" ");
    //Console.WriteLine();

    Console.WriteLine("Enter your number of choice");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Prime numbers from 1 to {0} are: ", num);
    for (int i = 2; i <= num; i++)
    {
        if (PrimeNumber(num, i) == 1)
        {
            Console.WriteLine(i);
        }
    }
}

static int PrimeNumber(int num, int i)
{
    int holder = 0;

    for (int i = 2; i < num; i++)
    {
        if (num < 1)
        {
            return 0;
        }
        else if (num % i == 0)
        {
            return 0;
        }
        else if (num > 1)
        {
            holder = 1;
        }
    }
    if (holder == 1)
    {
        Console.WriteLine("" + i);
    }
    return PrimeNumber(i + 1, num);

}
