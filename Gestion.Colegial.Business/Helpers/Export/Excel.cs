using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion.Colegial.Business.Helpers.Export
{
    public class Excel
    {
        private string[] ignoredHeader;

        public string[] IgnoredHeader { get => ignoredHeader; set => ignoredHeader = value; }

        private int error;
        public int Error { get => error; }

        public void DataSource(DataTable dataTable)
        {
            Microsoft.Office.Interop.Excel.Application excelExport = new Microsoft.Office.Interop.Excel.Application();
            excelExport.Application.Workbooks.Add(Type.Missing);

            int indiceColumna = 0;
            foreach (var columna in dataTable.Columns)
            {
                indiceColumna++;
                excelExport.Cells[1, indiceColumna].Value = columna.ToString();
                //excelExport.Cells[1, indiceColumna].Style.Font.Size = 22;
                excelExport.Cells[1, indiceColumna].Font.Bold = true;
                excelExport.Cells[1, indiceColumna].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(206, 211, 220));
                excelExport.Cells[1, indiceColumna].Columns.AutoFit();
            }

            int indiceFila = 0;
            foreach (DataRow fila in dataTable.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataColumn columna in dataTable.Columns)
                {
                    indiceColumna++;
                    excelExport.Cells[indiceFila + 1, indiceColumna] = fila[columna].ToString();
                }
            }
            excelExport.Columns.AutoFit();
            excelExport.Visible = true;
        }

        //public void FormatAsTable(Excel.Range SourceRange, string TableName, string TableStyleName)
        //{
        //    SourceRange.Worksheet.ListObjects.Add(XlListObjectSourceType.xlSrcRange,
        //    SourceRange, System.Type.Missing, XlYesNoGuess.xlYes, System.Type.Missing).Name =
        //        TableName;
        //    SourceRange.Select();
        //    SourceRange.Worksheet.ListObjects[TableName].TableStyle = TableStyleName;
        //}



        //En face Beta
        public void PrintDataGridView(DataGridView dataGridView)
        {

            if (dataGridView.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelExport = new Microsoft.Office.Interop.Excel.Application();
                excelExport.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    string hd = dataGridView.Columns[i - 1].HeaderText;
                    foreach (var item in ignoredHeader)
                    {
                        if (hd == item)
                        {
                            continue;
                            //MessageBox.Show(hd);
                        }
                        else
                        {
                            excelExport.Cells[1, i] = hd;

                        }

                    }

                }





                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelExport.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelExport.Columns.AutoFit();
                excelExport.Visible = true;


                //foreach (DataGridViewColumn Columns in dataGridView.Columns)
                //{
                //    foreach (var header in ignoredHeader)
                //    {
                //        if (Columns.HeaderText != header)
                //        {
                //            MessageBox.Show(Columns.HeaderText);
                //        }
                //    }
                //}

                for (int i = 0; i < dataGridView.Rows.Count - 2; i++)
                {

                }
            }
        }
    }
}
