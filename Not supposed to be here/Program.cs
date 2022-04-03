using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number within the range of 1 to 100");
            Console.Write("Enter the number of your choice:  ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (number < 0)
            {
                Console.WriteLine("Number is not valid");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number > 0)
            {
                Convert2Words(number);
            }
        }

        static string UnitNumbers(int number)
        {
            if (number == 1)
            {
                return "One";
            }
            else if (number == 2)
            {
                return "Two";
            }
            else if (number == 3)
            {
                return "Three";
            }
            else if (number == 4)
            {
                return "Four";
            }
            else if (number == 5)
            {
                return "Five";
            }
            else if (number == 6)
            {
                return "Six";
            }
            else if (number == 7)
            {
                return "Seven";
            }
            else if (number == 8)
            {
                return "Eigth";
            }
            else if (number == 9)
            {
                return "Nine";
            }
            else if (number == 10)
            {
                return "Ten";
            }
            else if (number == 11)
            {
                return "Eleven";
            }
            else if (number == 12)
            {
                return "Twelve";
            }
            else if (number == 13)
            {
                return "Thirteen";
            }
            else if (number == 14)
            {
                return "Fourteen";
            }
            else if (number == 15)
            {
                return "Fifteen";
            }
            else if (number == 16)
            {
                return "Sixteen";
            }
            else if (number == 17)
            {
                return "Seventeen";
            }
            else if (number == 18)
            {
                return "Eighteen";
            }
            else if (number == 19)
            {
                return "Nineteen";
            }
            return " ";
        }
        static string TensNumber(int number)
        {

            if (number >= 20 && number < 30)
            {
                return "Twenty";
            }
            else if (number >= 30 && number <= 40)
            {
                return "Thirty";
            }
            else if (number >= 40 && number < 50)
            {
                return "Fourty";
            }
            else if (number >= 50 && number < 60)
            {
                return "Fifty";
            }
            else if (number >= 60 && number < 70)
            {
                return "Sixty";
            }
            else if (number >= 70 && number < 80)
            {
                return "Seventy";
            }
            else if (number >= 80 && number < 90)
            {
                return "Eighty";
            }
            else if (number >= 90 && number < 100)
            {
                return "Ninety";
            }
            return " ";
        }

        static string Hundred(int number)
        {
            if (number == 100)
            {
                return "Hundred";
            }
            else
            {
                return " ";
            }
        }

        static void Convert2Words(int number)
        {
            if (number >= 1 && number < 20)
            {
                Console.WriteLine(UnitNumbers(number));
            }
            else if (number >= 20 && number < 100)
            {
                int firstWord = number % 10;

                Console.WriteLine(TensNumber(number) + " " + " " + UnitNumbers(firstWord));
            }
            else if (number == 100)
            {
                int firstWord = number / 100;
                Console.WriteLine(UnitNumbers(firstWord) + " " + Hundred(number));
            }
            else if (number > 100)
            {
                Console.Write("Limit of 100 is exceeded. ");
                Console.WriteLine("You entered: {0}", number);
            }
        }
    }
}
