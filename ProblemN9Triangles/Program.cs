using System;

namespace ProblemN9Triangles
{
    class Program
    {
        static int TriangleInequality(int a, int b, int c)
        {
            if ((a + b >= c) && (a + c >= b) && (b + c >= a))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of triplets: ");
            int tricount = int.Parse(Console.ReadLine());
            string answer = "";
            string[] numbers;
            for(int i = 0; i < tricount; i++)
            {
                numbers = Console.ReadLine().Split();
                answer += (TriangleInequality(int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]))).ToString() + " ";
            }
            Console.WriteLine(answer);
        }
    }
}
