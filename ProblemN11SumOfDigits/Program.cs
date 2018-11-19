using System;
using System.Collections.Generic;

//Input data are in the following format:

//first line contains N - the number of values to process;
//and then N lines will follow describing the values for which sum of digits should be calculated by 3 integers A B C;
//for each case you need to multiply A by B and add C(i.e.A* B + C) - then calculate sum of digits of the result.

//Answer should have N results, also separated by spaces. For example:


namespace ProblemN11SumOfDigits
{
    class Program
    {
        static int SumOfDigits(int number)
        {
            int a = number;
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of lines with values: ");
            int nol = int.Parse(Console.ReadLine());
            Console.Write("Enter Values: ");
            List<string> values = new List<string>();
            for (int i = 0; i < nol; i++)
            {
                values.Add(Console.ReadLine());
            }

            foreach(string s in values)
            {
                string[] tokens = s.Split(" ");
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[2]);
                Console.Write("{0} ", SumOfDigits((a * b) + c));
            }
        }
    }
}
