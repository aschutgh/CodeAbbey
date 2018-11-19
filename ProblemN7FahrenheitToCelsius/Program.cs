using System;
using System.Collections.Generic;

//You are to write program to convert degrees of Fahrenheit to Celsius.

//Input data contains N+1 values, first of them is N itself (Note that you should not try to convert it).
//Answer should contain exactly N results, rounded to nearest integer and separated by spaces.


namespace ProblemN7FahrenheitToCelsius
{
    class Program
    {
        static int FtoC (int TempInF)
        {
            double F = TempInF;
            double C = (F - 32.0) / 1.8;
            return (int)Math.Round(C); 
        }

        static void Main(string[] args)
        {
            string[] tempFvalues;
            Console.WriteLine("Enter temperatures in fahrenheit separated by spaces. The first value should be the number of temperatures.");
            Console.Write("> ");
            tempFvalues = Console.ReadLine().Split(" ");

            for(int i = 1; i < int.Parse(tempFvalues[0])+1; i++)
            {
                int TempInC = FtoC(int.Parse(tempFvalues[i]));
                Console.Write("{0} ", TempInC);
            }
        }
    }
}
