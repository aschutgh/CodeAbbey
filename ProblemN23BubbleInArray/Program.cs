using System;
using System.Numerics;
using System.IO;
using System.Collections.Generic;

namespace ProblemN23BubbleInArray
{
    class Program
    {
        static BigInteger MyChecksum(int[] intarray, int seed, int limit)
        // seed is 113
        // limit is 10000007
        {
            BigInteger result = new BigInteger(0);

            for (int i = 0; i < intarray.Length; i++)
            {
                result += intarray[i];
                result *= seed;
                result %= limit;
            }
            return result;
        }

        static void intswap(ref int a, ref int b)
        {
            int temp = 0;
            if (b < a)
            {
                temp = a;
                a = b;
                b = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input line with positive numbers ending with -1: ");
            string[] inputStr = Console.ReadLine().Split(" ");
            int[] numbers = new int[inputStr.Length - 1];
            for(int i = 0; i < inputStr.Length - 1; i++)
            {
                numbers[i] = int.Parse(inputStr[i]);
            }

            int swapcounter = 0;

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] < numbers[i])
                {
                    intswap(ref numbers[i], ref numbers[i + 1]);
                    swapcounter += 1;
                }
            }
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("{0} ", numbers[i]);
            //}
            Console.WriteLine("{0} {1}", swapcounter, MyChecksum(numbers, 113, 10000007));
        }
    }
}
