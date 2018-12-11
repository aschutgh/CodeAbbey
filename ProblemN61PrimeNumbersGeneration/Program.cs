using System;
using System.Collections.Generic;

namespace ProblemN61PrimeNumbersGeneration
{
    class Program
    {
        static bool Prime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(0);
            int primectr = 0;
            int inttotest = 2;
            while(primectr < 200000)
            {
                if (Prime(inttotest) == true)
                {
                    primes.Add(inttotest);
                    primectr += 1;
                    inttotest += 1;
                }
                else
                {
                    inttotest += 1;
                }
            }

            Console.Write("Number of indices: ");
            int noi = int.Parse(Console.ReadLine());
            Console.WriteLine("Input indices separated by spaces: ");
            string[] indexstr = Console.ReadLine().Split();
            int[] indices = new int[indexstr.Length];
            for(int i = 0; i < indexstr.Length; i++)
            {
                indices[i] = int.Parse(indexstr[i]);
            }
             
            foreach(int i in indices)
            {
                Console.Write($"{primes[i]} ");
            }
            
        }
    }
}
