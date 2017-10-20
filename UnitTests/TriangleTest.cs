using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class TriangleTest
    {
        [Test]
        [TestCase(12, 258, TestName = "Тестирование Triangle при длине 12 и высоте 258")]
        [TestCase(4.358, 28, TestName = "Тестирование Triangle при длине 4.358 и высоте 28")]
        [TestCase(541, 3.85, TestName = "Тестирование Triangle при длине 541 и высоте 3.85")]
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестирование Triangle при длине MaxValue и высоте MaxValue")]
        [TestCase(double.MaxValue - 1, double.MaxValue - 1, TestName = "Тестирование Triangle при длине MaxValue - 1 и высоте MaxValue - 1")]
        public void GetSquare(double _length, double _height)
        {
            var triangle = new Triangle(_length, _height);
            var triangleSquare = triangle.Square;
        }
    }
}
