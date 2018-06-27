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
    }
}
