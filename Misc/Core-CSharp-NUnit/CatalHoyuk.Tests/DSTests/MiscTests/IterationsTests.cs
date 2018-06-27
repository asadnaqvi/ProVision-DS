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
    }
}
