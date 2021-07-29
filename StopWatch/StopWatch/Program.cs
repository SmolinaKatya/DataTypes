using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum1 = 0;
            double sum2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                var PackageTime = System.Diagnostics.Stopwatch.StartNew();
                PackageTime.Start();
                object o = i;
                PackageTime.Stop();
                sum1 += PackageTime.ElapsedTicks;
                var UnpackageTime = System.Diagnostics.Stopwatch.StartNew();
                UnpackageTime.Start();
                i = (int)o;
                UnpackageTime.Stop();
                sum2 += UnpackageTime.ElapsedTicks;
            }
            Console.WriteLine("{0:0.0000}", sum1/100);
            Console.WriteLine("{0:0.0000}", sum2/100);
        }
         
    }
}
