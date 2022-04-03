using System;

namespace Another
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 2; i < 100; i++)
            {
                int holder = 1;
                
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        holder = 0;
                        break;
                    }
                }
                if (holder==1)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }
    }
}
