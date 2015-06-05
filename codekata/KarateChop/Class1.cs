using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;

namespace KarateChop
{
    [TestFixture]
    public class Class1
    {
        const int unsuccessful = -1;
        const int empty = 0;
        private Karate SUT;

        [SetUp]
        public void SetUp()
        {
            SUT = new Karate();
        }

        [Test]
        public void Given_Null_Array_Returns_Unsuccessful()
        {
            var result = SUT.chop(It.IsAny<int>(), null);
            result.Should().Be(unsuccessful);
        }
        [Test]
        public void Given_Empty_Array_Returns_Unsuccessful()
        {
            var result = SUT.chop(It.IsAny<int>(), new int[empty]);
            result.Should().Be(unsuccessful);
        }
        [Test]
        public void Given_Integer_Not_in_Array_Returns_Unsuccessful()
        {
            var result = SUT.chop(1, new[] {2} );
            result.Should().Be(unsuccessful);
        }
        [Test]
        public void Given_Integer_in_Array_Returns_Index()
        {
            var result = SUT.chop(1, new[] { 1 });
            result.Should().Be(0);
        }
    }
}
