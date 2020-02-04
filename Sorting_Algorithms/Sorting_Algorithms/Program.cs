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
            int swaps = 0;
            List<int> numberlist = new List<int>();
            Random number = new Random();
            for (int i = 0; i < 100000; i++)
            {
                int num = number.Next(1, 1000001);
                numberlist.Add(num);
            }
            List<int> bubblesort = new List<int>(numberlist);
            
            Stopwatch bubblewatch = new Stopwatch();
            bubblewatch.Start();
            for (int i = 0; i < bubblesort.Count - 1; i++)
            {
                for (int j = 0; j < bubblesort.Count - 1; j++)
                {
                    if (bubblesort[j] > bubblesort[j + 1])
                    {
                        int a = bubblesort[j];
                        int b = bubblesort[j + 1];
                        Swap(ref a, ref b);
                        swaps++;
                    }
                }
            }
            bubblewatch.Stop();
            TimeSpan tsb = bubblewatch.Elapsed;
            double bubbletime = tsb.TotalMilliseconds;
            Console.WriteLine("Bubblesort time: " + bubbletime + " milliseconds");
            Console.WriteLine("Number of swaps for bubble sort: " + swaps);

            

            Console.ReadLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
