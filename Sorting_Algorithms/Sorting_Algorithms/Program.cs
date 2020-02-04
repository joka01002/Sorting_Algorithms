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
            List<int> numberlist = new List<int>();
            Random number = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = number.Next(1, 1000001);
                numberlist.Add(num);
            }
            List<int> bubblesort = new List<int>(numberlist);
            List<int> insertionsort = new List<int>(numberlist);
            List<int> mergesort = new List<int>(numberlist);

            double bubbletime = sort.BubbleSort(bubblesort);
            Console.WriteLine("Bubblesort time: " + bubbletime + " milliseconds");

            double insertiontime = sort.InsertionSort(insertionsort);
            Console.WriteLine("Insertionsort time: " + insertiontime + " milliseconds");

            double mergetime = sort.MergeSort(mergesort);
            Console.WriteLine("Mergesort time: " + mergetime + " milliseconds");



            Console.ReadLine();
        }
    }
}
