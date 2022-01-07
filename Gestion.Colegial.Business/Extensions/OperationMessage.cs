using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Extensions
{
    internal class OperationMessage
    {

        private static string _error = "Ocurrio un error inesperado en la operación.";
        private static string _ok = "La operacion se ha completado con éxito.";
        public static string Error { get => _error; }
        public static string Ok { get => _ok; }

        public OperationMessage()
        {
        }
    }
}
