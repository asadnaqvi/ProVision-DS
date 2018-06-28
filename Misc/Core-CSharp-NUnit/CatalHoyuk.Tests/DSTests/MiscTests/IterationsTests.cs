using System;
using System.Collections.Generic;
using System.Text;
using CatalHoyuk.DS.Misc;
using NUnit.Framework;

namespace CatalHoyuk.Tests.DSTests.MiscTests
{
    [TestFixture]
    public class IterationsTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void GetBiggestBinaryGap_PositiveNumber_0(int input)
        {
            int result = new Iterations().GetBiggestBinaryGap(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetBiggestBinaryGap_Five_1()
        {
            int result = new Iterations().GetBiggestBinaryGap(5);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void GetBiggestBinaryGap_Nine_2()
        {
            int result = new Iterations().GetBiggestBinaryGap(9);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void GetBiggestBinaryGap_MinusOne_0()
        {
            int result = new Iterations().GetBiggestBinaryGap(-1);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void ReverseArray_Null_empty()
        {
            var result = new Iterations().ReverseArray(null);
            Assert.That(result, Is.EqualTo(new int[0]));
        }
        [Test]
        public void ReverseArray_Ary_ReverseAry()
        {
            int[] ary = { 1, 2, 10 };
            int[] reverseAry = { 10, 2, 1 };
            var result = new Iterations().ReverseArray(ary);
            Assert.That(result, Is.EqualTo(reverseAry));
        }
        [TestCase(new int[0], 1)]
        [TestCase(new int[0], 0)]
        [TestCase(new int[1] { 10 }, 0)]
        [TestCase(new int[1] { 10 }, 10)]
        public void RotateArrayKTimes_Zero_SameArray(int[] ary, int k)
        {
            var result = new Iterations().RotateArrayKTimes(ary, k);
            Assert.That(result, Is.EqualTo(ary));
        }
        //[TestCase(new int[1] { 10 }, -1)]
        //[TestCase(new int[1] { 10 }, 1001)]
        //public void RotateArrayKTimes_Exception_ItemsOutOfBoundry(int[] ary, int k)
        //{
        //    var result = new Iterations().RotateArrayKTimes(ary, k);
        //    Assert.That(result, Is.EqualTo(new Exception("Items out of range")));
        //}
        [Test]
        public void RotateArrayKTimes_Array_RotatedArray()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            var result = new Iterations().RotateArrayKTimes(A, K);
            Assert.That(result, Is.EqualTo(new int[5] { 9, 7, 6, 3, 8 }));
        }
    }
}
