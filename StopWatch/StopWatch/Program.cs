using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var PackageTime = System.Diagnostics.Stopwatch.StartNew();
            PackageTime.Start();
            int i = 123;
            object o = i;
            PackageTime.Stop();
            Console.WriteLine(PackageTime.Elapsed);
            var UnpackageTime = System.Diagnostics.Stopwatch.StartNew();
            UnpackageTime.Start();
            i = (int)o;
            UnpackageTime.Stop();
            Console.WriteLine(UnpackageTime.Elapsed);

        }
    }
}
