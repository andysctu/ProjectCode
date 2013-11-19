// ------------------------------------------------------------------- 
// Department of Electrical and Computer Engineering 
// University of Waterloo 
// 
// Student Name:    Andy Tu 
// Userid:          astu
// ID number:       20509407
// 
// Assignment:      weekly assignment 9 (wa9)
// Submission Date: November 18th, 2013
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work. 
// 
// Acknowledgements: 
// Starting point from Learn
// -------------------------------------------------------------------

using System;
using System.Diagnostics;

static class Program
    {
        // Test quick sort on a double array.
        private static void Main()
        {
            Random r = new Random();
            Stopwatch s = new Stopwatch();

            // Create an array of random values.  Time how long this takes.
            s.Reset();
            s.Start();
            double[] myArray = new double[(int)10e6];
            for (int i = 0; i < myArray.Length; i++) myArray[i] = r.Next();
            s.Stop();
            Console.WriteLine("Random array size: {0:n0}", myArray.Length);
            Console.WriteLine("  Time to create: {0}", s.Elapsed);

            // Sort the array using quick sort.  Time how long this takes.
            s.Reset();
            s.Start();
            Sorters.QuickSort(myArray);
            // myArray.QuickSort( );
            s.Stop();
            Console.WriteLine("Array sorted using quick sort");
            Console.WriteLine("  Time to sort: {0}", s.Elapsed);

            // Display the first five and last five values.
            Console.WriteLine("Some array values");
            if (myArray.Length <= 10)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("  [{0}]: {1}", i, myArray[i]);
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("  [{0}]: {1}", i, myArray[i]);
                }
                Console.WriteLine("  ...");
                for (int i = myArray.Length - 5; i < myArray.Length; i++)
                {
                    Console.WriteLine("  [{0}]: {1}", i, myArray[i]);
                }
            }

            // Check that the array is sorted.  Time how long this takes.
            s.Reset();
            s.Start();
            bool isSorted = true;
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < myArray[i - 1]) isSorted = false;
            }
            s.Stop();
            Console.WriteLine("Check whether the array is sorted: {0}", isSorted);
            Console.WriteLine("  Time to check: {0}", s.Elapsed);
        }
    }

    // QuickSort (partition-exchange sort) implementation.
    static class Sorters
    {
        // Public interface to quick sort.
        // The statement 'Sorters.QuickSort( a );' will sort the double array a.
        public static void QuickSort(double[] a)
        {
            PartitionExchangeSort(a, 0, a.Length - 1);
        }

        // The private recursive implementation.
        private static void PartitionExchangeSort(double[] a, int left, int right)
        {
            // Special cases.
            if (a == null) return;
            if (right - left < 1) return;

            // Estimate the median.  Place three elements in order.
            int middle = (left + right) / 2;
            if (a[left] > a[middle]) Swap(ref a[left], ref a[middle]);
            if (a[middle] > a[right]) Swap(ref a[middle], ref a[right]);
            if (a[left] > a[middle]) Swap(ref a[left], ref a[middle]);
            if (right - left <= 2) return;

            int leftScan = left + 1;
            int rightScan = right - 2;
            
            Swap(ref a[middle], ref a[right - 1]);

            while (leftScan <= rightScan)
            {
                if (a[leftScan] > a[right - 1])
                {
                    Swap(ref a[leftScan], ref a[rightScan]);
                    rightScan--;
                }
                else
                {
                    leftScan++;
                }
            }

            Swap(ref a[leftScan], ref a[right - 1]);

            PartitionExchangeSort(a, left, rightScan);
            PartitionExchangeSort(a, leftScan, right);
        }

        // Swap two values.
        private static void Swap(ref double first, ref double second)
        {
            double temp = first;
            first = second;
            second = temp;
        }
    }

    // Extension methods for sorting.
    static class SortExtensions
    {
        // QuickSort for double arrays.
        // The expression 'a.QuickSort( )' will sort the double array a.
        public static void QuickSort(this double[] a)
        {
            Sorters.QuickSort(a);
        }
    }