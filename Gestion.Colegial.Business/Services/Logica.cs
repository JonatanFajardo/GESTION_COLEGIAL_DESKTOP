using System.Windows.Forms;
//using Gestion.Colegial.DataAccess.Clases;


namespace Gestion.Colegial.Business.Services
{
    public class Logica
    {
        /// <summary>
        /// Conversor de string a palabras
        /// </summary>
        /// <param name="palabra"></param>
        /// <param name="indice"></param>
        /// <returns></returns>
        public static string explode(string palabra, int indice)
        {
            string[] words = palabra.Split(' ');
            return words[indice];
        }

        /// <summary>
        /// Limpia los controles dentro del formulario
        /// </summary>
        /// <param name="vaciar">Opcional, no necesario</param>
        public static void Limpiar(Control vaciar)
        {
            foreach (Control item in vaciar.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    //vaciar.Text = "";
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;

                }

            }
        }

        /// <summary>
        /// Limpia los controles dentro de un panel
        /// </summary>
        /// <param name="vaciar">Opcional, no necesario</param>
        /// <param name="panel">Nombre del panel</param>
        public static void Limpiar(Control vaciar, Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }

            }
        }

        //public static void Limpiar(Control vaciar, RadioButton radioButton1, RadioButton radioButton2)
        //{
        //    foreach (Control item in vaciar.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            ((TextBox)item).Clear();
        //            vaciar.Text = "";
        //        }
        //        else if (item is ComboBox)
        //        {
        //            ((ComboBox)item).SelectedIndex = 0;
        //        }
        //    }
        //}

        //== VALIDAMOS

        /// <summary>
        /// validamos que los TexBoxJN no esten vacios en caso de que la propiedad este en true
        /// </summary>
        /// <param name="TexBoxjn"></param>
        //public static async Task<Boolean> validarCamposVacios(Control TexBoxjn)
        //{

        //    Boolean validar = false;
        //    foreach (Control item in TexBoxjn.Controls)
        //    {
        //        if (item is TexBoxJN)
        //        {
        //            if (((TexBoxJN)item).Empty == TexBoxJN.EdtEmpty.True)
        //            {
        //                if (string.IsNullOrEmpty(item.Text))
        //                {
        //                    validar = true;
        //                }
        //                else
        //                {
        //                    validar = false;
        //                }
        //            }
        //        }
        //    }
        //    return validar;
        //}
    }


}
