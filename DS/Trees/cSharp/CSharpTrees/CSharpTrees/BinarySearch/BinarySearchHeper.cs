using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrees.BinarySearch
{
    public class BinarySearchHeper
    {
        public static int BinarySearch(int key, int[] array, int min, int max)
        {
            if (max < min)
            {
                return -1;
            }
            var midPoint = FindMidPoint(min, max);
            if (array[midPoint] < key) { return BinarySearch(key, array, midPoint + 1, max); }
            else if (array[midPoint] > key) { return BinarySearch(key, array, min, midPoint - 1); }
            else return midPoint;
        }
        private static int FindMidPoint(int min, int max)
        {
            return (min + max) / 2;
        }
    }
}
