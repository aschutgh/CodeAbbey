using System;
using System.Collections.Generic;

// correct rounding occurs with doubles

namespace ProblemN16AverageOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of lines: ");
            int nol = int.Parse(Console.ReadLine());
            List<string> lwn = new List<string>(); //line with numbers
            for(int i = 0; i  < nol; i++)
            {
                lwn.Add(Console.ReadLine());
            }
            foreach(string s in lwn)
            {
                double sum = 0;
                string[] numbers = s.Split();
                //Console.WriteLine("Regel met getallen: {0}", numbers);
                for (int i = 0; i < numbers.Length - 1; i++) // Last number is zero. It should not be used in the calculation of the average
                {
                    //Console.WriteLine("Dit getal wordt erbij geteld: {0}", int.Parse(numbers[i]));
                    sum += double.Parse(numbers[i]);
                }
                //Console.WriteLine("De totale som is: {0}", sum);
                //Console.WriteLine("We delen de som door: {0}", numbers.Length - 1);
                double average = sum / ((double)(numbers.Length - 1));
                Console.Write("{0} ", Math.Round(average));
            }
        }
    }
}
