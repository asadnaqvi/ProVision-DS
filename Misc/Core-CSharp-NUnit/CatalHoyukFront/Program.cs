using CatalHoyuk.DS.Misc;
using System;

namespace CatalHoyukFront
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetBiggestBinaryGapFront();
            RotateArrayKTimes_Array_RotatedArray();
        }
        static void GetBiggestBinaryGapFront()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            var length = new Iterations().GetBiggestBinaryGap(input);
            Console.WriteLine($"maximum binary gap for {input} is {length}");
            Console.ReadLine();
        }
        static void RotateArrayKTimes_Array_RotatedArray() {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            var result = new Iterations().RotateArrayKTimes(A, K);
            Console.ReadLine();
        }
    }
}
