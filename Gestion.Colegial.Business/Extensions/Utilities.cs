using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Extensions
{
    public class Utilities
    {
        /// <summary>
        /// Corrobora si una fecha cumple la edad minima requerida.
        /// </summary>
        /// <param name="date">Fecha a corroborar.</param>
        /// <param name="edad">Restricción de edad deseada.</param>
        /// <returns></returns>
        public static bool EdadMinima(DateTime date, int edad)
        {
            int EdadActual = DateTime.Now.Year - date.Year;
            if (EdadActual >= edad || EdadActual < 0)
                return false;

            return true;
        }

    }
}
