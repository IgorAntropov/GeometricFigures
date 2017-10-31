namespace Model
{
    /// <summary>
    /// Интерфейс геометрических фигур.
    /// </summary>
    interface Ifigure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Square { get; }

        /// <summary>
        /// Расчет площади фигуры.
        /// </summary>
        /// <returns></returns>
        double Calculate();
    }
}
