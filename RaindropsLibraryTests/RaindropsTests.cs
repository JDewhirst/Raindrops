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

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(-15)]
        [TestCase(-30)]
        public void GetFactorResult_NumberHasAFactorOf3And5_ReturnsPlingPlang(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("PlingPlang"));
        }

        [TestCase(21)]
        [TestCase(63)]
        [TestCase(-21)]
        [TestCase(-63)]
        public void GetFactorResult_NumberHasAFactorOf3And7_ReturnsPlingPlong(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("PlingPlong"));
        }

        [TestCase(35)]
        [TestCase(70)]
        [TestCase(-35)]
        [TestCase(-70)]
        public void GetFactorResult_NumberHasAFactorOf5And7_ReturnsPlangPlong(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("PlangPlong"));
        }

        [TestCase(105)]
        [TestCase(210)]
        [TestCase(-105)]
        [TestCase(-210)]
        [TestCase(0)]
        public void GetFactorResult_NumberHasAFactorOf3And5And7_ReturnsPlingPlangPlong(int input)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo("PlingPlangPlong"));
        }

        [TestCase(1, "1")]
        [TestCase(-1, "-1")]
        [TestCase(34, "34")]
        [TestCase(-34, "-34")]
        public void GetFactorResult_NumberDoesNotHaveAFactorOf3Or5Or7_ReturnsNumber(int input, string expected)
        {
            var result = Raindrops.Raindrops.GetFactorResult(input);
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}