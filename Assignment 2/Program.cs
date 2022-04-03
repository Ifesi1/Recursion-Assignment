using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string word = Console.ReadLine();
            Charax(word);
        }

        static int Charax(string word)
        {
            if (word == " ")
            {
                return 0;
            }
            return word.Length;
        }
    }
}
