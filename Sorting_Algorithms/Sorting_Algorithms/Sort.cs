using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    public class Sort
    {
        public double BubbleSort(List<int> bubblesort)
        {
            Stopwatch bubblewatch = new Stopwatch();
            bubblewatch.Start();
            for (int i = 0; i < bubblesort.Count - 1; i++)
            {
                for (int j = 0; j < bubblesort.Count - 1; j++)
                {
                    if (bubblesort[j] > bubblesort[j + 1])
                    {
                        int a = bubblesort[j];
                        bubblesort[j] = bubblesort[j + 1];
                        bubblesort[j + 1] = a;
                    }
                }
            }
            bubblewatch.Stop();
            return bubblewatch.Elapsed.TotalMilliseconds;
        }

        public double InsertionSort(List<int> insertionsort)
        {
            Stopwatch insertionwatch = new Stopwatch();
            insertionwatch.Start();
            for (int i = 1; i < insertionsort.Count; i++)
            {
                int j = i;
                while (j > 0 && insertionsort[j-1] > insertionsort[j])
                {
                    int a = insertionsort[j-1];
                    insertionsort[j-1] = insertionsort[j];
                    insertionsort[j] = a;
                    j--;
                }
            }
            insertionwatch.Stop();
            return insertionwatch.Elapsed.TotalMilliseconds;
        }

        public double InsertionSort2(List<int> insertionsort)
        {
            Stopwatch insertionwatch = new Stopwatch();
            insertionwatch.Start();
            for (int i = 1; i < insertionsort.Count; i++)
            {
                int a = insertionsort[i];
                int j = i-1;
                while (j >= 0 && insertionsort[j] > a)
                {
                    insertionsort[j+1] = insertionsort[j];
                    j--;
                }
                insertionsort[j+1] = a;
            }
            insertionwatch.Stop();
            return insertionwatch.Elapsed.TotalMilliseconds;
        }

        public double MergeSortInit(List<int> mergesort)
        {
            Stopwatch mergewatch = new Stopwatch();
            mergewatch.Start();
            List<int> SortedList = MergeSort(mergesort);
            mergewatch.Stop();
            return mergewatch.Elapsed.TotalMilliseconds;
        }

        public double QuickSort(List<int> quicksort)
        {

        }

        private List<int> MergeSort(List<int> mergesort)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            
            if (mergesort.Count <= 1)
            {
                return mergesort;
            }
            
            int x = mergesort.Count / 2;
            left = mergesort.GetRange(0, x);
            right = mergesort.GetRange(x, mergesort.Count - x);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left = left.GetRange(1, left.Count - 1);
                }
                else
                {
                    result.Add(right[0]);
                    right = right.GetRange(1, right.Count - 1);
                }
            }

            if (left.Count > 0)
            {
                result.AddRange(left);
            }
            else
            {
                result.AddRange(right);
            }
            return result;
        }
    }
}
