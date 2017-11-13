using System;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class NegativeRectangleTest
    {
        [Test]
        [TestCase(-6, -15, TestName = "Тестирование Rectangle при длине -6 и ширине -15")]
        [TestCase(-9.7, -11.25, TestName = "Тестирование Rectangle при длине -9.7 и ширине -11.25")]
        [TestCase(-49, -123, TestName = "Тестирование Rectangle при длине -49 и ширине -123")]
        public void GetSquare(double _length, double _width)
        {
            Assert.That(() => { new Rectangle(_length, _width); }, Throws.TypeOf(typeof (ArgumentException)));
        }
    }
}
