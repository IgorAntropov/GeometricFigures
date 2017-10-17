using System;

namespace Model
{
    /// <summary>
    /// Создание класса Треугольник.
    /// </summary>
    public class Triangle : Ifigure
    {
        /// <summary>
        /// Длина треугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Высота треугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Валидация и присвоение.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Triangle(double a, double b)
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
            this._height = b;
        }

        /// <summary>
        /// Расчет площади треугольника.
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return (0.5*_length)*_height;
        }
    }
}
