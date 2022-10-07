using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Searching
    {
        public static int StraightSearch(int[] a, int x)
        {
            int i = 0;
            while (i < a.Length && a[i] != x)
                i++;
            if (i < a.Length)
                return i;
            else
                return -1;
        }
        public static int BinarySearch(int[] a, int x)
        {
            int middle, left = 0, right = a.Length - 1;
            do
            {
                middle = (left + right) / 2;
                if (x > a[middle])
                    left = middle + 1;
                if (x < a[middle])
                    right = middle - 1;
            }
            while ((a[middle] != x) && (left <= right));
            if (a[middle] == x)
                return middle;
            else
                return -1;
        }
    }
}
