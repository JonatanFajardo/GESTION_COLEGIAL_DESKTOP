using Gestion.Colegial.Business.Services;
using Gestion.Colegial.UI.FormsBase;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Alumnos
{
    public partial class List : FormBase
    {
        public List()
        {
            InitializeComponent();
            Reload();
        }

        private async void Reload(string valor = "")
        {
            var ServiceResult = await AlumnosServices.List(valor);
        }

        /// <summary>
        /// Agrega un nuevo registro.
        /// </summary>
        public async override void Agregar()
        {
            MessageBox.Show("Test");
            Add add = new Add();
            ShowForm(add);
        }

        public async override void CellContentDGV(DataGridViewCellEventArgs e)
        {
            
            if (dataGridViewJN1.Rows[e.RowIndex].Cells[0].Selected)
            {
                int id =  (int)dataGridViewJN1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Add add = new Add(id, this);
                add.Show();
            }
        }

        private void pnBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
