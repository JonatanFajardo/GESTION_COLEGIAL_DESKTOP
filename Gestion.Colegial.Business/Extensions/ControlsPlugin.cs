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
        /// Padre en el cual se encuentra el control.
        /// </summary>
        /// <param name="control"></param>
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
