using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            List<int> numberList = new List<int>();
            Random number = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = number.Next(1, 1000001);
                numberList.Add(num);
            }
            List<int> bubbleSort = new List<int>(numberList);
            List<int> insertionSort = new List<int>(numberList);
            List<int> mergeSort = new List<int>(numberList);
            List<int> quickSortL = new List<int>(numberList);
            List<int> quickSortH = new List<int>(numberList);
            List<int> linqSort = new List<int>(numberList);

            double bubbleTime = sort.BubbleSort(bubbleSort);
            Console.WriteLine("Bubblesort time: " + bubbleTime + " milliseconds");

            double insertionTime = sort.InsertionSort(insertionSort);
            Console.WriteLine("Insertionsort time: " + insertionTime + " milliseconds");

            double mergeTime = sort.MergeSortInit(mergeSort);
            Console.WriteLine("Mergesort time: " + mergeTime + " milliseconds");

            double quickTimeL = sort.QuickSort(quickSortL, true);
            Console.WriteLine("Quicksort Lomuto time: " + quickTimeL + " milliseconds");

            double quickTimeH = sort.QuickSort(quickSortH, false);
            Console.WriteLine("Quicksort Hoare time: " + quickTimeH + " milliseconds");

            double listTime = sort.LinqSort(linqSort);
            Console.WriteLine("C# listsort time: " + listTime + " milliseconds");

            Console.ReadLine();
        }
    }
}
