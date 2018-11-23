using System;
using System.Numerics;

namespace ProblemN17ArrayChecksum
{
    class Program
    {

        static BigInteger MyChecksum(int[] intarray, int seed, int limit)
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


        static void Main(string[] args)
        {
            Console.WriteLine("Length of array: ");
            int loa = int.Parse(Console.ReadLine());

            string[] ints_str;
            ints_str = Console.ReadLine().Split(" ");
            int[] ints = new int[loa];
            for(int i = 0; i < loa; i++)
            {
                ints[i] = int.Parse(ints_str[i]);
            }
            Console.WriteLine("{0}", MyChecksum(ints, 113, 10000007));
        }
    }
}
