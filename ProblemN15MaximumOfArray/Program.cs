using System;
using System.IO;

// Console.ReadLine() standard behaviour: read a maximum of 256 characters.

namespace ProblemN15MaximumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // modify Console.ReadLine properties
            // source: https://stackoverflow.com/questions/5557889/console-readline-max-length/44135529
            byte[] inputBuffer = new byte[4096];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
            //string strInput = Console.ReadLine();


            Console.Write("Input 300 integers separated by a space: ");
            string[] numbers_string;
            numbers_string = Console.ReadLine().Split(" ");
            int[] numbers = new int[300];
            for(int i = 0; i < 300; i++)
            {
                numbers[i] = int.Parse(numbers_string[i]);
            }
            int maximum = numbers[0];
            int minimum = numbers[0];
            for(int i = 0; i < 300; i++)
            {
                if (numbers[i] > maximum)
                    maximum = numbers[i];
                if (numbers[i] < minimum)
                    minimum = numbers[i];
            }
            Console.Write("{0} {1}", maximum, minimum);
        }
    }
}
