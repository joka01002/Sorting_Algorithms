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
            List<Sort> numberlist = new List<Sort>();
            Random number = new Random();
            for (int i = 0; i < 10000; i++)
            {
                int num = number.Next(1, 1000001);
                numberlist.Add(new Sort(num));
            }
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
        }
    }
}
