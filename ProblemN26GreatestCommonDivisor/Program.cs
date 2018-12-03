using System;

namespace ProblemN26GreatestCommonDivisor
{
    class Program
    {

        static int mygcd(int a, int b)
        {
            if (b > a) return mygcd(b, a);

            if (a % b == 0) return b;

            return mygcd(b, a % b);
        }

        static int mylcm(int a, int b)
        {
            return (a * b) / mygcd(a, b);
        }


        static void Main(string[] args)
        {
            Console.Write("Number of test cases: ");
            int ntc = int.Parse(Console.ReadLine());

            string answer = "";

            for(int i = 0; i < ntc; i++)
            {
                string[] input_str = Console.ReadLine().Split(" ");
                int a = int.Parse(input_str[0]);
                int b = int.Parse(input_str[1]);
                int gcdab = mygcd(a, b);
                int lcmab = mylcm(a, b);
                answer = answer + "(" + gcdab.ToString() + " " + lcmab.ToString() + ") ";
            }
            Console.Write(answer);
        }
    }
}
