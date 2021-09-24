using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Helpers.Alert
{
    public class AlertEntity
    {
        public string Success;
        public string Warnin;
        public string Error;
        public string Information;

        public AlertEntity()
        {
            Success = "Rergistro almacenado correctamente.";
            Warnin = "";
            Error = "Ha ocurrido un error al almacenar los datos.";
            Information = "";
        }
    }
}
