using System;
using System.Collections.Generic;
using System.IO;

//Here is an array of length M with numbers in the range 1 ... N, where N is less than or equal to 20. We are to go through it and count how many times each number is encountered.
//I.e.it is like Vowel Count task, but we need to maintain more than one counter.Be sure to use separate array for them, do not create a lot of separate variables, one for each counter.
//Input data contain M and N in the first line.
//The second (rather long) line will contain M numbers separated by spaces.
//Answer should contain exactly N values, separated by spaces.First should give amount of 1-s, second - amount of 2-s and so on.

namespace ProblemN21ArrayCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[4096];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            Console.Write("Input m and n on the same line and separated by a space: ");
            string[] inputMN = Console.ReadLine().Split(" ");
            int m = int.Parse(inputMN[0]);
            int n = int.Parse(inputMN[1]);
            Console.Write("Input m numbers in the range 1..n:");
            string[] inputnumbers = Console.ReadLine().Split(" ");

            SortedDictionary<int, int> intcount = new SortedDictionary<int, int>();

            for(int i = 0; i < m; i++)
            {
                if (!intcount.ContainsKey(int.Parse(inputnumbers[i])))
                {
                    intcount.Add(int.Parse(inputnumbers[i]), 1);
                }
                else if (intcount.ContainsKey(int.Parse(inputnumbers[i])))
                {
                    intcount[int.Parse(inputnumbers[i])] += 1;
                }
            }

            foreach(int s in intcount.Keys)
            {
                Console.Write("{0} ", intcount[s]);
            }
        }
    }
}
