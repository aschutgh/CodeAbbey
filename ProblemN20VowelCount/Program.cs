using System;
using System.Collections.Generic;

//Input data contain number of test-cases in the first line.
//Then the specified number of lines follows each representing one test-case.
//Lines consist only of lowercase English(Latin) letters and spaces.
//Answer should contain the number of vowels in each line, separated by spaces.


namespace ProblemN20VowelCount
{
    class Program
    {
        static int CountVowels(string line)
        {
            int nov = 0; // number of vowels
            //var hashSet = new HashSet<int>() { 1, 2, 3 };
            var vowelSet = new HashSet<string>() { "a", "e", "i", "o", "u", "y" };

            for (int i = 0; i < line.Length; i++)
            {
                if (vowelSet.Contains(line.Substring(i, 1)))
                {
                    nov += 1;
                }
                    
            }
            return nov;
        }

        static void Main(string[] args)
        {
            Console.Write("Number  of lines: ");
            int nol = int.Parse(Console.ReadLine());
            string[] lines = new string[nol];

            for (int i = 0; i < nol; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < nol; i++)
            {
                Console.Write("{0} ", CountVowels(lines[i]));
            }
        }
    }
}
