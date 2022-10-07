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
            Console.WriteLine("Generating array...");
            int N = 1000000; // Количество элементов специально для перегрева устройства.
            int[] a = new int[N];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                a[i] = r.Next() % 500;
            Console.WriteLine("Array generation complete.");
            Sorts sorts = new Sorts();
            Timing timing = new Timing();
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("");
            Console.WriteLine("Enter value from 1 to 3 and press <Enter>");
            Console.WriteLine("1. Selection sorting");
            Console.WriteLine("2. Exchange sorting");
            Console.WriteLine("3. Insertion sorting");
            string key = Console.ReadLine();

            if (key == "1")
            {
                stopwatch.Start();
                timing.StartTime();

                sorts.SortSelection(a);

                stopwatch.Stop();
                timing.StopTime();

                Console.WriteLine("Stopwatch result in selection sorting is: " + stopwatch.Elapsed.ToString());
                Console.WriteLine("Timing in selection sorting is: " + timing.Result().ToString());
            }
            else if (key == "2")
            {
                stopwatch.Start();
                timing.StartTime();

                sorts.BubbleSort(a);

                stopwatch.Stop();
                timing.StopTime();

                Console.WriteLine("Stopwatch result in bubble sorting is: " + stopwatch.Elapsed.ToString());
                Console.WriteLine("Timing result in bubble sorting is: " + timing.Result().ToString());
            }
            else if (key == "3")
            {
                stopwatch.Start();
                timing.StartTime();

                sorts.SortInsertion(a);

                stopwatch.Stop();
                timing.StopTime();

                Console.WriteLine("Stopwatch result in insertion sorting is: " + stopwatch.Elapsed.ToString());
                Console.WriteLine("Timing result in insertion sorting is: " + timing.Result().ToString());
            }
            else
            {
                Console.WriteLine("Operation complete!");
            }
        }
    }
}

