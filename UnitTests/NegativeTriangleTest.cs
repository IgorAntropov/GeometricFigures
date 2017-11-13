using System;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class NegativeTriangleTest
    {
        [Test]
        [TestCase(-12, -258, TestName = "Тестирование Triangle при длине -12 и высоте -258")]
        [TestCase(-4.358, -28, TestName = "Тестирование Triangle при длине -4.358 и высоте -28")]
        [TestCase(-541, -3.85, TestName = "Тестирование Triangle при длине -541 и высоте -3.85")]
        public void GetSquare(double _length, double _height)
        {
            Assert.That(() => { new Triangle(_length, _height); }, Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
