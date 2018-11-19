using System;
using System.Collections.Generic;

namespace ProblemN4MinimumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number os pairs to compare: ");
            int nofp = int.Parse(Console.ReadLine());
            List<string> ptoc = new List<string>();
            for (int i = 0; i < nofp; i++)
            {
                ptoc.Add(Console.ReadLine());
            }

            foreach (string s in ptoc)
            {
                string[] tokens = s.Split(" ");
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                if (a < b)
                {
                    Console.Write("{0} ", a);
                }
                else if (b < a)
                {
                    Console.Write("{0} ", b);
                }
                else if (a == b)
                {
                    Console.Write("{0} ", a);
                }
            }
        }
    }
}