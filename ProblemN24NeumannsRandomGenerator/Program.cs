using System;

// FIXME: start over

namespace ProblemN24NeumannsRandomGenerator
{
    class Program
    {
        static int NRG(int n)
        {
            int square = n * n;
            string sr = square.ToString();
            int srl = sr.Length;
            if (sr.Length < 8)
            {
                string lz = string("0", 8 - srl);
                sr = lz + sr;
            }


        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
