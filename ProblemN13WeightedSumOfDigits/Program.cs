using System;

namespace ProblemN13WeightedSumOfDigits
{
    class Program
    {
        static int Wsd(string number)
        {
            int ws = 0;

            for(int i = 0; i < number.Length; i++)
            {
                ws += (i + 1) * int.Parse(number.Substring(i, 1));
            }

            return ws;
        }

        static void Main(string[] args)
        {
            Console.Write("Number of digits to be processed: ");
            int nod = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split(" ");
            for(int i = 0; i < nod; i++)
            {
                Console.Write("{0} ", Wsd(numbers[i]));
            }
        }
    }
}
