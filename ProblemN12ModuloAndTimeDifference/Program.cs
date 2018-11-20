using System;
using System.Collections.Generic;


//FIXME: finish this program

//In this task we are given several pair of timestamps. We suppose that both dates in the pair are always in the same month, so only number of day will be given. We want to calculate difference between timestamps in each pair.

//Input data: the first line contains number of test-cases, other lines contain test-cases themselves.
//Each test-case contains 8 numbers, 4 for each timestamp: day1 hour1 min1 sec1 day2 hour2 min2 sec2 (second timestamp will always be later than first).
//Answer: for each test-case you are to output difference as following (days hours minutes seconds) - please note brackets - separated by spaces.

namespace ProblemN12ModuloAndTimeDifference
{
    class Program
    {
        static int TSToSec(int day, int hour, int min, int sec)
        {
            return day * 24 * 3600 + hour * 3600 + min * 60 + sec;
        }

        static (int day, int hour, int min, int sec) SecsToTS(int seconds)
        {
            int nday = 0;
            int nhour = 0;
            int nmin = 0;
            int nsec = 0;

            nday = seconds / (24 * 3600);
            seconds = seconds % (24 * 3600);
            nhour = seconds / 3600;
            seconds = seconds % 3600;
            nmin = seconds / 60;
            seconds = seconds % 60;
            nsec = seconds;
            (int day, int hour, int min, int sec) TStamp = (nday, nhour, nmin, nsec);
            return TStamp;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lines with timestamps: ");
            int nol = int.Parse(Console.ReadLine());
            List<string> lwithts = new List<string>(); // lwiths: line with timestamps
            for (int i = 0; i < nol; i++)
            {
                lwithts.Add(Console.ReadLine());
            }

            foreach(string s in lwithts)
            {
                string[] TSs = s.Split(" ");
                List<int> TSs_ints = new List<int>();
                foreach(string t in TSs)
                {
                    TSs_ints.Add(int.Parse(t));
                }
                int TS2secs = TSToSec(TSs_ints[4], TSs_ints[5], TSs_ints[6], TSs_ints[7]);
                int TS1secs = TSToSec(TSs_ints[0], TSs_ints[1], TSs_ints[2], TSs_ints[3]);
                (int day, int hour, int min, int sec) ResTS = SecsToTS(TS2secs - TS1secs);
                Console.Write("({0} {1} {2} {3}) ", ResTS.day, ResTS.hour, ResTS.min, ResTS.sec);
            }

        }
    }
}
