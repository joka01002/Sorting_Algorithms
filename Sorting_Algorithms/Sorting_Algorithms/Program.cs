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
            List<int> insertionSort2 = new List<int>(numberList);
            List<int> mergeSort = new List<int>(numberList);
            List<int> quickSort = new List<int>(numberList);
            List<int> listSort = new List<int>(numberList);

            double bubbleTime = sort.BubbleSort(bubbleSort);
            Console.WriteLine("Bubblesort time: " + bubbleTime + " milliseconds");

            double insertionTime = sort.InsertionSort(insertionSort);
            Console.WriteLine("Insertionsort time: " + insertionTime + " milliseconds");

            double insertionTime2 = sort.InsertionSort2(insertionSort2);
            Console.WriteLine("Second Insertionsort time: " + insertionTime2 + " milliseconds");

            double mergeTime = sort.MergeSortInit(mergeSort);
            Console.WriteLine("Mergesort time: " + mergeTime + " milliseconds");

            //double quickTime = sort.QuickSort(quickSort);
            //Console.WriteLine("Quicksort time: " + quickTime + " milliseconds");

            double listTime = sort.ListSort(listSort);
            Console.WriteLine("C# listsort time: " + listTime + " milliseconds");

            Console.ReadLine();
        }
    }
}
