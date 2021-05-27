using NUnit.Framework;
using Raindrops;

namespace RaindropsLibraryTests
{
    public class Tests
    {
        [TestCase(3)]
        [TestCase(36)]
        [TestCase(-3)]
        [TestCase(-36)]
        public void GetFactorResult_NumberHasAFactorOf3_ReturnsPling(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("Pling"));
        }

        [TestCase(5)]
        [TestCase(25)]
        [TestCase(-5)]
        [TestCase(-25)]
        public void GetFactorResult_NumberHasAFactorOf5_ReturnsPlang(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("Plang"));
        }

        [TestCase(7)]
        [TestCase(28)]
        [TestCase(-7)]
        [TestCase(-28)]
        public void GetFactorResult_NumberHasAFactorOf7_ReturnsPlong(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("Plong"));
        }


        
    }
}