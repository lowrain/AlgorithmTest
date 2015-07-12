using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 13, 27, 49, 55, 4, 49, 38, 65, 97, 26, 8, 33, 84, 68, 72 };
            //Sorting.BubbleSort(intArray);
            //Sorting.DirectInsertionSort(intArray);
            //Sorting.StraightSelectSort(intArray);
            //Sorting.MergeSort(intArray, 0, intArray.Length - 1, new int[intArray.Length]);
            Sorting.QuickSort(intArray, 0, intArray.Length - 1);
            intArray.ToList().ForEach(i => Console.Write(i + " "));
            Console.Read();
        }
    }
}
