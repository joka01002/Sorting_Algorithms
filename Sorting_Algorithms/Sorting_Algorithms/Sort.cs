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
        public double BubbleSort(List<int> bubbleSort)
        {
            Stopwatch bubbleWatch = new Stopwatch();
            bubbleWatch.Start();
            for (int i = 0; i < bubbleSort.Count - 1; i++)
            {
                for (int j = 0; j < bubbleSort.Count - 1; j++)
                {
                    if (bubbleSort[j] > bubbleSort[j + 1])
                    {
                        int a = bubbleSort[j];
                        bubbleSort[j] = bubbleSort[j + 1];
                        bubbleSort[j + 1] = a;
                    }
                }
            }
            bubbleWatch.Stop();
            return bubbleWatch.Elapsed.TotalMilliseconds;
        }

        public double InsertionSort(List<int> insertionSort)
        {
            Stopwatch insertionWatch = new Stopwatch();
            insertionWatch.Start();
            for (int i = 1; i < insertionSort.Count; i++)
            {
                int j = i;
                while (j > 0 && insertionSort[j-1] > insertionSort[j])
                {
                    int a = insertionSort[j-1];
                    insertionSort[j-1] = insertionSort[j];
                    insertionSort[j] = a;
                    j--;
                }
            }
            insertionWatch.Stop();
            return insertionWatch.Elapsed.TotalMilliseconds;
        }

        public double InsertionSort2(List<int> insertionSort)
        {
            Stopwatch insertionWatch = new Stopwatch();
            insertionWatch.Start();
            for (int i = 1; i < insertionSort.Count; i++)
            {
                int a = insertionSort[i];
                int j = i-1;
                while (j >= 0 && insertionSort[j] > a)
                {
                    insertionSort[j+1] = insertionSort[j];
                    j--;
                }
                insertionSort[j+1] = a;
            }
            insertionWatch.Stop();
            return insertionWatch.Elapsed.TotalMilliseconds;
        }

        public double MergeSortInit(List<int> mergeSort)
        {
            Stopwatch mergeWatch = new Stopwatch();
            mergeWatch.Start();
            List<int> SortedList = MergeSort(mergeSort);
            mergeWatch.Stop();
            return mergeWatch.Elapsed.TotalMilliseconds;
        }

        public double QuickSort(List<int> quickSort)
        {
            Stopwatch quickWatch = new Stopwatch();
            quickWatch.Start();
            quickWatch.Stop();
            return quickWatch.Elapsed.TotalMilliseconds;
        }

        public double ListSort(List<int> listSort)
        {
            Stopwatch listWatch = new Stopwatch();
            listWatch.Start();
            listSort.Sort();
            listWatch.Stop();
            return listWatch.Elapsed.TotalMilliseconds;
        }

        private List<int> MergeSort(List<int> mergeSort)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            
            if (mergeSort.Count <= 1)
            {
                return mergeSort;
            }
            
            int x = mergeSort.Count / 2;
            left = mergeSort.GetRange(0, x);
            right = mergeSort.GetRange(x, mergeSort.Count - x);

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
