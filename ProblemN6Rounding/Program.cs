using System;
using System.Collections.Generic;


namespace ProblemN6Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of pairs to divide: ");
            int nop = int.Parse(Console.ReadLine());
            List<string> nofptd = new List<string>();
            for (int i = 0; i < nop; i++)
            {
                nofptd.Add(Console.ReadLine()); // number of pairs to divide
            }

            foreach(string s in nofptd)
            {
                string[] tokens = s.Split(" ");
                double qt = Double.Parse(tokens[0]) / Double.Parse(tokens[1]);
                Console.Write("{0} ", Math.Round(qt));
            }

        }
    }
}