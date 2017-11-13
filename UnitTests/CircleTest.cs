using Model;
using NUnit.Framework;


namespace UnitTests
{
    [TestFixture]
    class CircleTest
    {
        [Test]
        [TestCase(9.58, TestName = "Тестирование Circle при радиусе 9.58")]
        [TestCase(12, TestName = "Тестирование Circle при радиусе 12")]
        [TestCase(2.2578, TestName = "Тестирование Circle при радиусе 2.2578")]
        [TestCase(double.MaxValue, TestName = "Тестирование Circle при радиусе MaxSquare.")]
        [TestCase(double.MaxValue - 1, TestName = "Тестирование Circle при радиусе MaxSquare - 1.")]
        public void GetSquare(double _radius)
        {
            var circle = new Circle(_radius);
        }
    }
}
