using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс геометрических фигур.
    /// </summary>
    interface Ifigure
    {

        /// <summary>
        /// Расчет площади фигуры.
        /// </summary>
        /// <returns></returns>
        double Calculate();
    }
}
