using JNControls.Controles;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Helpers.Controles
{
    public class Validation
    {
        /// <summary>
        /// Valida que los JNTexBox no esten vacios. Retorna un true si este esta vacio, y false en caso contrario.
        /// </summary>
        /// <param name="JNTexBox">conjunto de controles del form</param>
        /// <returns>Boolean</returns>
        public static Boolean CamposVacios(Control jnTexBox)
        {
            Boolean validar = false;
            foreach (Control item in jnTexBox.Controls)
            {
                if (item is JNTexBox)
                {
                    if (((JNTexBox)item).Require == JNTexBox.TrueFalse.True)
                    {
                        if (string.IsNullOrEmpty(((JNTexBox)item).Texts))
                        {
                            validar = true;
                        }

                        //else
                        //{
                        //    validar = false;
                        //}
                    }
                    //if (((JNTexbox)item).Clear == JNTexbox.EdtClear.True)
                    //{
                    //    ((JNTexbox)item).Text = "";

                    //}
                }
            }
            return validar;
        }


        //public static Control CamposVaciosR(Control jnTexBox)
        //{
        //    Boolean validar = false;
        //    foreach (Control item in jnTexBox.Controls)
        //    {
        //        if (item is JNTexBox)
        //        {

        //            if (((JNTexBox)item).Clear == JNTexBox.EdtClear.True)
        //            {
        //                ((JNTexBox)item).Text = "";

        //            }
        //        }
        //    }
        //    return jnTexBox;
        //}

        //public static Control CamposVaciosR(Control jnTexBox)
        //{
        //    Boolean validar = false;
        //    foreach (Control item in jnTexBox.Controls)
        //    {
        //        if (item is JNTexBox)
        //        {

        //            if (((JNTexBox)item).Clear == JNTexBox.EdtClear.True)
        //            {
        //                ((JNTexBox)item).Text = "";

        //            }
        //        }
        //    }
        //    return jnTexBox;
        //}


    }
}
