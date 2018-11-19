using System;
using System.Collections.Generic;

namespace ProblemN5MinimumOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of triplets to compare: ");
            int noft = int.Parse(Console.ReadLine());
            List<string> ttoc = new List<string>();
            for(int i = 0; i < noft; i++)
            {
                ttoc.Add(Console.ReadLine());
            }

            foreach (string s in ttoc)
            {
                string[] tokens = s.Split(" ");
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[2]);
                int min = a;
                if (min > b)
                    min = b;
                if (min > c)
                    min = c;
                Console.Write("{0} ", min);
            }
        }
    }
}