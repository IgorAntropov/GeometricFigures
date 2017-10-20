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
        /// Геттер для площади круга
        /// </summary>
        public double Square => Calculate();

        /// <summary>
        /// Геттер/сеттер для площади круга
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

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
