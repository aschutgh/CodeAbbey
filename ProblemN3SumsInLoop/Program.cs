using System;
using System.Collections.Generic;

namespace ProblemN3SumsInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of pairs to sum: ");
            int nofp = int.Parse(Console.ReadLine());
            List<string> ptos = new List<string>();
            for (int i = 0; i < nofp; i++)
            {
                ptos.Add(Console.ReadLine());
            }

            foreach(string s in ptos)
            {
                string[] tokens = s.Split(" ");
                Console.WriteLine(int.Parse(tokens[0]) + int.Parse(tokens[1]));
            }
        }
    }
}
