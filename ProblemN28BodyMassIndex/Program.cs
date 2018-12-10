using System;
using System.Globalization;

namespace ProblemN28BodyMassIndex
{
    class Program
    {
        static string BodyMassIndex(double weight, double height)
        {
            double bmi = 0.0;
            bmi = weight / Math.Pow(height, 2.0);
            //Console.WriteLine(bmi);
            if (bmi < 18.5)
            {
                return "under";
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                return "normal";
            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                return "over";
            }
            else return "obese";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Problem 28 Body Mass Index");
            Console.Write("Number of people: ");
            int nop = int.Parse(Console.ReadLine());
            string[] inputstrings = new string[nop];
            for (int i = 0; i < nop; i++)
            {
                inputstrings[i] = Console.ReadLine();
                //Console.Write(inputstrings[i]);
            }
            //double weight = 0.0;
            //double height = 0.0;
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint;
            provider = new CultureInfo("en-GB");

            for (int i = 0; i < nop; i++)
            {
                double[] wh = new double[2];
                string[] whstr = inputstrings[i].Split(" ");
                wh[0] = double.Parse(whstr[0], style, provider);
                wh[1] = double.Parse(whstr[1], style, provider);
                // Console.WriteLine("doubles uitgelezen {0} {1}", wh[0], wh[1]);
                Console.Write("{0} ", BodyMassIndex(wh[0], wh[1]));
            }
            //Console.WriteLine(BodyMassIndex(80.0, 1.96));
        }
    }
}
