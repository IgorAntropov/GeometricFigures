using System;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class NegativeCircleTest
    {
        [Test]
        [TestCase(-12, TestName = "Тестирование Circle при радиусе -12")]
        [TestCase(-5245, TestName = "Тестирование Circle при радиусе -5245")]
        [TestCase(-2.2578, TestName = "Тестирование Circle при радиусе -2.2578")]
        public void GetSquare(double _radius)
        {
            Assert.That(() => { new Circle(_radius); }, Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
