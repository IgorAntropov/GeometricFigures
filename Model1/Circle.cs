using System;

namespace Model
{
    /// <summary>
    /// Создание класса Круг.
    /// </summary>
    public class Circle : Ifigure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        private double _radius;

        /// <summary>
        /// Валидация и присвоение.
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            if (r < 0.0)
            {
                throw new ArgumentException("Отрицательный радиус");
            }
            this._radius = r;
        }

        /// <summary>
        /// Расчет площади круга.
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return Math.PI*(_radius*_radius);
        }
    }
}
