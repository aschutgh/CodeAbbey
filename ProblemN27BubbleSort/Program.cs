using System;
using System.Linq;

namespace ProblemN27BubbleSort
{
    class Program
    {
        static void printarray(int[] intarray)
        {
            foreach(var item in intarray)
            {
                Console.Write("{0} ", item);
            }
        }

        static int[] bubblesort(int[] numbers, int noe)
        {
            bool swapped = true;
            int swapctr = 0;
            int passctr = 0;
            while (swapped == true)
            {
                swapped = false;
                passctr += 1;
                Console.WriteLine("Number of passes: {0}", passctr);
                for(int i = 0; i < noe - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapctr += 1;
                        Console.WriteLine("Number of swaps: {0}", swapctr);
                        swapped = true;
                    }
                }
                printarray(numbers);
            }
            int[] psinfo = new int[2];
            psinfo[0] = passctr;
            psinfo[1] = swapctr;
            return psinfo;
        }

        static void Main(string[] args)
        {
            Console.Write("Number of elements to be sorted: ");
            int noe = int.Parse(Console.ReadLine());
            int[] numbers = new int[noe];
            Console.Write("The elements separated by whitespace on one line: ");
            string[] numbersinput = Console.ReadLine().Split(" ");
            for(int i = 0; i < noe; i++)
            {
                numbers[i] = int.Parse(numbersinput[i]);
            }
            int[] psinfo = bubblesort(numbers, noe);
            Console.Write($"{psinfo[0]} {psinfo[1]}");
        }
    }
}
