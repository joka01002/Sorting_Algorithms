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

        public double MergeSort(List<int> mergesort)
        {
            Stopwatch mergewatch = new Stopwatch();
            mergewatch.Start();
            MergeSplit(mergesort);
            mergewatch.Stop();
            return mergewatch.Elapsed.TotalMilliseconds;
        }

        private List<int> MergeSplit(List<int> mergesort)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            
            if (mergesort.Count <= 1)
            {
                return mergesort;
            }
            
            foreach(int i in mergesort)
            {
                if (i < mergesort.Count / 2)
                {
                    left.Add(mergesort[i]);
                }
                else
                {
                    right.Add(mergesort[i]);
                }
            }


        }
    }
}
