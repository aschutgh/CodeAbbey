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
                if (a < b)
                {
                    if (b < c)
                    {
                        Console.Write("{0} ", a);
                    }
                    else if (c < b)
                    {
                        if (c < a)
                            Console.Write("{0} ", c);
                        else
                            Console.Write("{0} ", a);
                    }
                }
                if (b < a)
                {
                    if (a < c)
                    {
                        Console.Write("{0} ", b);
                    }
                    else if (c < a)
                    {
                        if (b < c)
                            Console.Write("{0} ", b);
                        else
                            Console.Write("{0} ", c);
                    }
                }
            }
        }
    }
}