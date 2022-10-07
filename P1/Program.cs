using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static P1.Searching;
using System.Collections;

namespace P1
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("If you want to proceed to sorting time tests, enter number <1> and press <Enter>");
            Console.WriteLine("If you want to proceed to searching time tests, enter number <2> and press <Enter>");
            string EntryKey = Console.ReadLine();
            if (EntryKey == "1")
                Sort();
            else if (EntryKey == "2")
                Search();
            Console.WriteLine("Select the right number!!!");
        }
        public static void Sort()
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
            Console.WriteLine("Enter value from 1 to 2 and press <Enter>");
            Console.WriteLine("1. Selection sorting");
            Console.WriteLine("2. Insertion sorting");
            string key = Console.ReadLine();
            Console.WriteLine("");

            if (key == "1")
            {
                Console.WriteLine("Processing...");
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
                Console.WriteLine("Processing...");
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
                Console.WriteLine("Select the right number!!!");
            }
        }
        public static void Search()
        {
            Console.WriteLine("Generating array...");
            int N = 1000000;
            int[] a = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
                a[i] = random.Next();
            Console.WriteLine("Array generation is complete.");
            Sorts sorts = new Sorts();
            Timing timing = new Timing();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("");

            Console.WriteLine("Enter value from 1 to 2 and press <Enter>");
            Console.WriteLine("1. Straight search");
            Console.WriteLine("2. Binary search(required array sorting)");
            string key = Console.ReadLine();
            Console.WriteLine("");

            if (key == "1")
            {
                Console.WriteLine("Enter a desired number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing...");
                stopwatch.Start();
                timing.StartTime();

                int z = StraightSearch(a, x);

                stopwatch.Stop();
                timing.StopTime();
                if (z == -1)
                {
                    Console.WriteLine("Couldn't find desired number position");
                }
                else
                {
                    Console.WriteLine("Desired number position is " + z);
                }
                Console.WriteLine("Stopwatch result in bubble sorting is: " + stopwatch.Elapsed.ToString());
                Console.WriteLine("Timing result in bubble sorting is: " + timing.Result().ToString());
            }
            else if (key == "2")
            {
                Console.WriteLine("Enter a desired number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Processing...");
                stopwatch.Start();
                timing.StartTime();

                sorts.SortInsertion(a);

                int z = BinarySearch(a, x);

                stopwatch.Stop();
                timing.StopTime();
                if (z == -1)
                {
                    Console.WriteLine("Couldn't find desired number position");
                }
                else
                {
                    Console.WriteLine("Desired number position is " + z);
                }
                Console.WriteLine("Stopwatch result in bubble sorting is: " + stopwatch.Elapsed.ToString());
                Console.WriteLine("Timing result in bubble sorting is: " + timing.Result().ToString());
            }
            else
                Console.WriteLine("Select the right number!!!");
        }
    }
}

