using NUnit.Framework;
using System;
using AddingTwoMinimals;

namespace AddingTwoMinimalsTests
{
    public class Tests
    {
        [Test]
        public void EmptyTest()
        {
            int[] array = { };
            Assert.Throws<InvalidOperationException>(() => Program.GetMinimalsSum(array));
        }

        [Test]
        public void SingleValueTest()
        {
            int[] array = { 1 };
            Assert.Throws<InvalidOperationException>(() => Program.GetMinimalsSum(array));
        }

        [Test]
        public void NullTest()
        {
            Assert.Throws<NullReferenceException>(() => Program.GetMinimalsSum(null));
        }

        [Test]
        public void MillionsLengthArrayTest()
        {
            int[] array = new int[100000];
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.GetMinimalsSum(array));
        }
    }
}