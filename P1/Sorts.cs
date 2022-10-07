using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace P1
{
    internal class Sorts
    {
        public void SortSelection(int[] a)
        {
            int N = a.Length;
            int min = 0, imin = 0, i;
            for (i = 0; i < N - 1; i++)
            {
                min = a[i]; imin = 1;
                // Поиск минимального элемента
                for (int j = i + 1; j < N; j++)
                    if (a[i] < min)
                    {
                        min = a[j]; imin = j;
                    }
                if (i != imin)
                {
                    // Добавление нового элемента в отсортированную часть
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
        }
        public void SortInsertion(int[] a)
        {
            int tmp = a[0];
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {
                int j = i - 1;
                while (j >= 0 && tmp < a[j]) // Сдвинуть элемент
                    a[j + 1] = a[j--];       
                a[j + 1] = tmp;              // Поставить элемент на своё место
            }
        }
        public void SortBinInsert(int[] a)
        {
            int N = a.Length;
            for (int i = 1; i <= N - 1 ; i++)
            {
                int tmp = a[i], left = 1, right = i - 1;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    // Определение индекса среднего элемента
                    if (tmp < a[m])
                        right = m - 1; // Сдвиг правой
                    else left = m + 1; // левой границы
                }
                for (int j = i - 1; j >= 0; j--)
                    a[j + 1] = a[j];   // Сдвиг элементов
                a[left] = tmp;         // Размещение элемента в нужном месте
            }
        }
        public void BubleSort(int[] a)
        {
            int N = a.Length;
            for (int i = 1; i < N; i++)
                for (int j = N - 1; j <= i; j--)
                    if (a[j - 1] > a[i])
                    {
                        int t = a[j - 1];
                        a[j - 1] = a[i];
                        a[j] = t;
                    }
        }
        public static void SortShaker(int[] a)
        {
            int left = 1, right = a.Length - 1, last = right;
            do
            {
                for (int j = right; j >= left; j--)
                    if (a[j - 1] > a[j])
                    {
                        int t = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = t;
                        last = j;
                    }
                left = last;
                for (int j = left; j <= right; j++)
                    if (a[j - 1] > a[j])
                    {
                        int t = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = t;
                        last = j;
                    }
                right = last - 1;
            }
            while (left < right);
        }
    }
}
