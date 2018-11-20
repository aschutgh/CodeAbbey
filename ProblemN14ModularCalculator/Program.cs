using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProblemN14ModularCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial number: ");
            int initNumber = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();

            bool next = true;

            while(next)
            {
                string line = Console.ReadLine();
                if (line != "")
                {
                    lines.Add(line);
                    if(line.Substring(0, 1) == "%")
                    {
                        next = false;
                    }
                }
            }

            BigInteger result = new BigInteger(initNumber);

            foreach(string s in lines)
            {
                string[] tokens;
                tokens = s.Split(" ");
                switch (tokens[0])
                 {
                    case "+":
                        result = result + int.Parse(tokens[1]);
                        break;
                    case "*":
                        result = result * int.Parse(tokens[1]);
                        break;
                    case "%":
                        result = result % int.Parse(tokens[1]);
                        break;
                    default:
                        break;
                 }
            }
            Console.WriteLine(result);
        }
    }
}
