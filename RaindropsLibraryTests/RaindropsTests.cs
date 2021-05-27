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


    }
}