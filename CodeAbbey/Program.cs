using System;

// FIXME: Add problem description to projects 1 to 6


namespace CodeAbbey
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ");
            Console.WriteLine(int.Parse(inputs[0]) + int.Parse(inputs[1]));
        }
    }
}
