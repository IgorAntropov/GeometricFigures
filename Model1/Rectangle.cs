using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Создание класса Прямоугольник.
    /// </summary>
    public class Rectangle : Ifigure
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Валидация и присвоение.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Rectangle(double a, double b)
        {
            if (a < 0.0)
            {
                throw new ArgumentException("Отрицательный радиус");
            }
            if (b < 0.0)
            {
                throw new ArgumentException("Отрицательный радиус");
            }
            this._length = a;
            this._width = b;
        }

        /// <summary>
        /// Расчет площади прямоугольника.
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return _length * _width;
        }
    }
}
