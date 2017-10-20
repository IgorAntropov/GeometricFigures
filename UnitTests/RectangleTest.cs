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
    class RectangleTest
    {
        [Test]
        [TestCase(6, 15, TestName = "Тестирование Rectangle при длине 6 и ширине 15")]
        [TestCase(9.7, 11.25, TestName = "Тестирование Rectangle при длине 9.7 и ширине 11.25")]
        [TestCase(49, 123, TestName = "Тестирование Rectangle при длине 49 и ширине 123")]
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестирование Rectangle при длине MaxValue и ширине MaxValue")]
        [TestCase(double.MaxValue - 1, double.MaxValue - 1, TestName = "Тестирование Rectangle при длине MaxValue - 1 и ширине MaxValue - 1")]
        public void GetSquare(double _length, double _width)
        {
            var rectangle = new Rectangle(_length, _width);
            var rectangleSquare = rectangle.Square;
        }
    }
}
