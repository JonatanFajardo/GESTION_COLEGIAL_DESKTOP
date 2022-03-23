using JNControls.Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Extensions
{
    public static class DGVExtended 
    {
        /// <summary>
        /// Establece botones con imagenes
        /// </summary>
        ///// <param name="position">Indicara el lado al que se orientaran los botones.</param>
        ///// <param name="name">Nombre que tendra la columna.</param>
        ///// <param name="image">Direccion de la imagen.</param>
        public static void AddBtn(this DataGridView dgv, List<DGVHeader> actionButtons)
        {//PositionDgv position, string[] name, string[] image, int[] size
            string[] img = new string[] { "image\\dgv\\Edit.png", "image\\dgv\\Details.png", "image\\dgv\\Delete.png" };
            DataGridViewImageColumn[] btn = new DataGridViewImageColumn[actionButtons.Count];
            int s = dgv.ColumnCount;
            for (int i = 0; i < actionButtons.Count; i++)
            {
                //if (posicion == PositionDgv.start)
                //{
                //    int count = dataGridViewJN1.RowCount;
                //        dataGridViewJN1.Columns[i].DisplayIndex = 1;
                //}
                btn[i] = new DataGridViewImageColumn();
                dgv.Columns.Add(btn[i]);
                btn[i].Name = $"{actionButtons[i].Name}";
                Image image1 = Image.FromFile("C:\\Users\\User\\Documents\\GitHub\\GESTION_COLEGIAL_DESKTOP\\Gestion.Colegial.UI\\Content\\" + img[i]);
                btn[i].Resizable = DataGridViewTriState.True;
                btn[i].Image = image1;
                dgv.Columns[actionButtons[i].Name].Width = actionButtons[i].Size;

            }

        }
    }
}
