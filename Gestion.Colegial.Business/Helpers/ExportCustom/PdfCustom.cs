using System;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Helpers.ExportCustom
{
    public class PdfCustom
    {
        /// <summary>
        /// Aplica formato general para toda la aplicacion
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="dgv"></param>
        public static void DataSource(string titulo, DataGridView dgv)
        {
            Export.PDF printer = new Export.PDF();
            printer.Title = titulo;
            printer.SubTitle = $"Fecha: {DateTime.Now.Date}";
            printer.SubTitleSpacing = 10;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = "Gestion Colegial";
            printer.FooterSpacing = 10;
            printer.PrintPreviewDataGridView(dgv);
            //printer.PrintDataGridView(dgv);

        }
    }
}
