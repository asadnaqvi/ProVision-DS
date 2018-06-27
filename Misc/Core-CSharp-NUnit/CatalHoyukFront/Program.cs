using CatalHoyuk.DS.Misc;
using System;

namespace CatalHoyukFront
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBiggestBinaryGapFront();
        }
        static void GetBiggestBinaryGapFront()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            var length = new Iterations().GetBiggestBinaryGap(input);
            Console.WriteLine($"maximum binary gap for {input} is {length}");
            Console.ReadLine();
        }
    }
}
