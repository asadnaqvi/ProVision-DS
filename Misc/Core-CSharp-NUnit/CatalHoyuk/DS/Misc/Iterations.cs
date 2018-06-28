using System;
using System.Collections.Generic;
using System.Text;

namespace CatalHoyuk.DS.Misc
{
    public class Iterations
    {
        public int GetBiggestBinaryGap(int num)
        {
            string s = Convert.ToString(num, 2);
            int i = 0, binaryGap = 0;
            int? counter = null;
            while (i < s.Length)
            {
                if (s[i] == '0')
                {
                    if (counter != null)
                    {
                        counter++;
                    }
                }
                if (s[i] == '1')
                {
                    if (counter != null)
                    {
                        if (binaryGap < counter)
                        {

                            binaryGap = Convert.ToInt32(counter);
                        }
                    }
                    counter = 0;
                }
                i++;
            }
            return binaryGap;
        }
        public int[] ReverseArray(int[] ary)
        {
            if (ary == null) return new int[0];
            Array.Reverse(ary);
            return ary;
        }
        /// <summary>
        /// N and K are integers within the range [0..100]
        /// each element of array A is an integer within the range [−1,000..1,000].
        /// </summary>
        /// <param name="ary"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] RotateArrayKTimes(int[] ary, int k)
        {
            
            if (ary.Length > 100 || ary.Length < 0 || k < 0 || k > 100)
            {
                throw new Exception("Items out of range");
            }
            // no need to rotate if ary is empty or it is required to rotate 0 times
            if (ary.Length == 0 || ary.Length == 1 || k == 0)
            {
                return ary;
            }
            for (int i = 0; i < k; i++)
            {
                ary = RotateArrayKTimesHelper(ary, k);
            }
            return ary;
        }
        private int[] RotateArrayKTimesHelper(int[] ary, int k)
        {
            var lastItem = ary[ary.Length - 1];
            int[] ary2 = new int[ary.Length];
            for (int i = 0; i < ary.Length - 1; i++)
            {
                ary2[i + 1] = ary[i];
            }
            ary2[0] = lastItem;
            return ary2;
        }
    }
}
