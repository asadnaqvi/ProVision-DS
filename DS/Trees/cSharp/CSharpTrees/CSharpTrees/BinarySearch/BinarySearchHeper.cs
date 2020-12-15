using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTrees.BinarySearch
{
    public class BinarySearchHeper
    {
        /// <summary>
        /// 1- max<min means we traversed the list and item not found
        /// 2- Find the mid point of the list
        /// 3- If key is greater than mid point then search for the right half of the list
        /// 4- If key is less than mid point then search for the left half of the list
        /// 5- if key equals to mid point then return mid point
        /// </summary>
        /// <param name="key">item that we need to find</param>
        /// <param name="array"> list of items. We are using int array for this example</param>
        /// <param name="min">minimum index</param>
        /// <param name="max">maximum index</param>
        /// <returns></returns>
        public static int BinarySearch(int key, int[] array, int min, int max)
        {
            if (max < min)
            {
                return -1;
            }
            var midPoint = FindMidPoint(array[min], array[max]);
            if (array[midPoint] < key) { return BinarySearch(key, array, midPoint + 1, max); }
            else if (array[midPoint] > key) { return BinarySearch(key, array, min, midPoint - 1); }
            else return midPoint;
        }
        private static int FindMidPoint(int min, int max)
        {
            return (min + max)/ 2;
        }
    }
}
