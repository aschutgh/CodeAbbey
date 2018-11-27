using System;
using System.Collections.Generic;

namespace ProblemN24NeumannsRandomGenerator
{
    class Program
    {
        static int Nrg(int n)
        {
            int square = n * n;
            string sr = square.ToString();
            int srl = sr.Length;
            if (sr.Length < 8)
            {
                string lz = new string('0', 8 - srl);
                sr = lz + sr;
            }
            sr = sr.Substring(2, 4);
            return int.Parse(sr);

        }
    
        static void Main(string[] args)
        {
            Console.Write("Amount of initial values: ");
            int nov = int.Parse(Console.ReadLine());
            string[] values_str = Console.ReadLine().Split(" ");
            int[] values_int = new int[nov];
            for(int i = 0; i < nov; i++)
            {
                values_int[i] = int.Parse(values_str[i]);
            }

            for(int i = 0; i < nov; i++)
            {
                int result = Nrg(values_int[i]);
                int ctr = 1;
                HashSet<int> encountered = new HashSet<int>();
                if (result != values_int[i])
                {
                    encountered.Add(values_int[i]);
                    encountered.Add(result);
                    ctr += 1;
                    while(true)
                    {
                        if (!encountered.Contains(Nrg(result)))
                        {
                            result = Nrg(result);
                            ctr += 1;
                            encountered.Add(result);
                        }
                        else break;
                    }
                }
                Console.Write("{0} ", ctr);
            }
        }
    }
}
