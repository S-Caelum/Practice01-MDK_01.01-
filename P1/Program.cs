using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static P1.Timing;
using static P1.Sorts;

namespace P1
{
    internal static class Program
    {
        public static void Main()
        {
            int N = 1000000000;
            int[] a = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                a[i] = rand.Next() % 500;
            Sorts sorts = new Sorts();
            Timing timing = new Timing();
            Stopwatch stopwatch = new Stopwatch();
            timing.StartTime();
            stopwatch.Start();
            sorts.SortInsertion(a);
            stopwatch.Stop();
            timing.StopTime();
            Console.WriteLine("Stopwatch: " + stopwatch.Elapsed.ToString());
            Console.WriteLine("Timer: " + timing.Result().ToString());
        }
    }
}

