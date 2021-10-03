using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Extensions
{
    public static class ControlsPlugin
    {
        /// <summary>
        /// Permite limpiar los controles.
        /// </summary>
        /// <remarks>
        /// Se debe de indicar como true la propiedad de Required.
        /// </remarks>
        /// <param name="control">Padre en el cual se encuentra el control.</param>
        public static void CleanIfCompleted(Control control)
        {
            foreach (var itemControl in control.Controls)
            {
                if (itemControl is JNTexBox)
                {
                    if (((JNTexBox)itemControl).CleanCompleted == true)
                    {
                        ((JNTexBox)itemControl).Texts = "";
                    }
                }
            }
        }
    }
}
