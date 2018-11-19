using System;

namespace ProblemN2SumInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of integers: ");
            int noi = int.Parse(Console.ReadLine());
            Console.Write("Integers to sum: ");
            string[] intstosum = Console.ReadLine().Split(" ");

            int total = 0;

            foreach(string s in intstosum)
            {
                total += int.Parse(s);
            }
            Console.WriteLine("Sum of entered integers: {0}", total);
        }
    }
}
