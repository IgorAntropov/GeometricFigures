using System;

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
        /// Геттер для площади прямоугольника
        /// </summary>
        public double Square => Calculate();

        /// <summary>
        /// Геттер\Сеттер для длины прямоугольника
        /// </summary>
        public double Length
        {
            get { return _length; }

            set { _length = value; }
        }

        /// <summary>
        /// Геттер\Сеттер для ширины прямоугольника
        /// </summary>
        public double Width
        {
            get { return _width; }

            set { _width = value; }
        }

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
            return _length*_width;
        }
    }
}
